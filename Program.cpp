#include <stdio.h>
#include <stdlib.h>
#include <string.h>
//Cau truc cay
struct StructTree {
	char Word[9];   //Tu co toi da 10 ki tu
	int Count;
	struct StructTree *Left, *Parent, *Right;
};
//Dinh nghia con tro kieu cau truc
typedef struct StructTree *Tree;
//Bien toan cuc la Cau truc cay,de 2 ham Input va Output khong can khai bao lai
Tree root = NULL;
//Ham duyet cay theo LNR va luu vao file
void LNR(Tree root, FILE* g) {        //Tree LNR
	if (root != NULL) {
		LNR(root->Left, g);
		//Xuat ra Console
		printf("|%10s\t|\t%d\t|\n", root->Word, root->Count);
		printf("=================================\n");
		//Xuat ra File
		fprintf(g, "|%10s\t|\t%d\t|\n", root->Word, root->Count);
		fprintf(g, "=================================\n");
		LNR(root->Right, g);
	}
}
//Ham duyet den Node nho nhat ( Node ben trai cuoi cung)
Tree EndLeftNode(Tree root) {
	Tree p = root;
	while (p->Left != NULL) p = p->Left;
	return p;
}
//Tao Node moi
Tree CreateNode(char str[], int Count) {
	Tree p = (Tree)malloc(sizeof(struct StructTree));
	if (p == NULL) {
		printf("Cap phat dong that bai !\n");
		return p;
	}
	p->Left = NULL;
	p->Parent = NULL;
	p->Right = NULL;
	strcpy(p->Word, str);
	p->Count = Count;
	return p;
}
//Them Node moi vao Cay
Tree InsertNode(Tree root, char str[], int Count) {
	if (root == NULL) root = CreateNode(str, Count);
	else if (strcmp(root->Word, str) >= 0) {
		root->Left = InsertNode(root->Left, str, Count);
		root->Left->Parent = root;
	}
	else {
		root->Right = InsertNode(root->Right, str, Count);
		root->Right->Parent = root;
	}
	return root;
}//Tim kiem Node trong Cay
Tree Search(Tree root, char str[]) {
	if (root == NULL) return NULL;
	//Tim thay tu thi tra ve tu
	if (strcmp(root->Word, str) == 0) return root;
	//Tim Node ben trai
	Tree p = Search(root->Left, str);
	if (p != NULL) return p;
	//Tim Node ben phai
	Tree q = Search(root->Right, str);
	if (q != NULL) return q;
}
//Kiem tra ki tu dac biet, 1 dung 0 sai
int IsAlpha(char c) {
	if (((int)c >= 65 && (int)c <= 90) || ((int)c >= 97 && (int)c <= 122)) return 1;
	return 0;
}
//Xoa Node khoi cay
Tree DeleteNode(Tree root, char str[]) {
	if (root == NULL) return root;
	//Duyet theo Node ben trai de xoa neu Node can xoa(str) nho hon Node hien tai
	if (strcmp(root->Word, str) > 0)
		root->Left = DeleteNode(root->Left, str);
	//Duyet theo Node ben phai de xoa neu Node can xoa(str) lon hon Node hien tai
	else if (strcmp(root->Word, str) < 0)
		root->Right = DeleteNode(root->Right, str);
	//Tim duoc Node can xoa roi thi Xoa no thoi
	else {
		if (root->Left == NULL) {
			Tree p = root->Right;
			free(root);
			return p;
		}
		else if (root->Right == NULL) {
			Tree p = root->Left;
			free(root);
			return p;
		}
		Tree p = EndLeftNode(root->Right);
		strcpy(root->Word, p->Word);
		root->Count = p->Count;
		root->Right = DeleteNode(root->Right, p->Word);
	}
	return root;
}
//Doc va xu ly
void Handling(FILE* f) {
	char Line[79];    //Mang dung de luu 1 dong van ban
	int n, Count;
	int k = 0;
	while (fscanf(f, "%s", Line) != EOF ) {
		//Chuyen tat ca thanh chu hoa , neu muon thanh chu thuong thi dung strlwr
		strupr(Line);
		//Mang luu nhung tu duy nhat (Unique) va khoi tao bang ""
		char UniqueWord[9];
		strcpy(UniqueWord, "");
		for (int i = 0; i < strlen(Line); i++) {
			if (IsAlpha(Line[i])) {
				n = strlen(UniqueWord);
				UniqueWord[n] = Line[i];
				UniqueWord[n + 1] = '\0';
			}
			if (!IsAlpha(Line[i]) || i == strlen(Line) - 1) {
				Tree search = Search(root, UniqueWord);
				if (search == NULL) {
					// Dem 100 tu dau tien
					if (k == 100) break;

					if (strcmp(UniqueWord, "") != 0) {
						k++;
						root = InsertNode(root, UniqueWord, 1);
						strcpy(UniqueWord, "");
					}
				}
				else {
					Count = search->Count;
					root = DeleteNode(root, UniqueWord);
					root = InsertNode(root, UniqueWord, ++Count);
					strcpy(UniqueWord, "");
				}
			}
		}
		strcpy(Line, "");    //Doc xong 1 Line roi thi khoi tao lai thanh "" de dung cho Line khac
	}
}
//Xu ly nhap tu Console
void ReadFromConsole() {
	printf("Chu y : De ket thuc viec nhap, dua con tro vao mot dong trong roi nhan Ctrl+Z sau do Enter ! \n");
	printf("*Moi ban nhap van ban vao day : \n\n");
	Handling(stdin);
}
//Xu ly nhap tu File
void ReadFromFile() {
    FILE *f = fopen("input.txt", "r");
	//Bao loi khi duong dan khong hop le
	if (f == NULL) {
		printf("\nLoi khi doc File , kiem tra lai duong dan !\n");
		exit(1);
	}
	Handling(f);
	fclose(f);
}
//Ham Input
void Input() {
	int select;
	printf("\t\t\t\tChuong trinh thong ke tan suat cac tu trong van ban !\n");
	printf("1. Nhap tu man hinh Console \n");
	printf("2. Nhap tu file input.txt \n");
	do {
		printf("Chon truong hop : ");
		scanf("%d", &select);
		if (select != 1 && select != 2) printf("Chon dung truong hop !\n");
	} while (select != 1 && select != 2);
	printf("---------------------------------------------------------------------------------------\n");
	if (select == 1) ReadFromConsole();
	if (select == 2) ReadFromFile();
}
//Ham Output
void Output() {
	FILE *g = fopen("output.txt", "w");
	//Xuat ra Console
	printf("\nBang ket qua \n");
	printf("=================================\n");
	printf("|\tTu\t|    Tan suat\t|\n");
	printf("=================================\n");
	//Xuat ra File
	fprintf(g, "Bang ket qua \n");
	fprintf(g, "=================================\n");
	fprintf(g, "|\tTu\t|    Tan suat\t|\n");
	fprintf(g, "=================================\n");
	LNR(root, g);
	fclose(g);
	printf("\nBang tan suat da duoc luu vao output.txt");
}
int main() {
	Input();
	Output();
	return 0;
}
