#include <cstdlib>
#include <iostream>
 
using namespace std; 

struct Node
{
 int Data;
 Node *link;
};

Node *CreateNode ()
{
 Node *newNode;
 newNode = new Node;
 cout<<"\n Ievadi skaitli kuru pievienot:     ";
 cin>>newNode->Data;
 newNode->link=NULL;
 return newNode;
}



void PrintList (Node *head)
{ 
Node *cur;
cout<<"Saraksta elementi:\n";
cur=head;        //1
while (cur!=NULL)
      {cout<<cur->Data<<"\n";    //2
      cur=cur->link;
      }
}



Node *addfirst(Node *head)
{
 Node *cur;
 cur=CreateNode();
 cur->link=head;
 head=cur;
 return head;
    }
Node  *AddLast(Node *head)
{
 Node *cur, *last;
 cur = head;
 
 while(cur->link!=NULL)
 {
    cur=cur->link;
 } 
 last = CreateNode();
 cur->link = last;
 return last;



}
void DeleteLast(Node *head)
{
 Node *cur;
 	cur = head;
    while(cur->link != NULL)
    {
     head = cur;
     cur=cur->link;   
    }
    delete cur;
    head->link = NULL;


 }
 
 
 Node  *DeleteFirst(Node *head)
{
 Node *cur;
 cur = head->link;
 delete head;
 head = cur;
 return head;
 



}
Node *Search(Node *head)
{
    Node *cur;
    cur = head;
    int x;
    cout<<"Ievadiet meklejamo elementu "; cin>>x;
    while(cur != NULL && cur ->Data !=x)
    {
     cur=cur->link;
    } 
    //if(cur->data == x);
    return cur;

}
void AddAfter(Node *head)
{
    Node *add;
    add = CreateNode();
    add -> link = head -> link;
    head-> link = add;


}
void AddBefore(Node *find)
{
    Node *cur;
    cur=CreateNode();
    cur->link=find->link;
    find->link=cur;



}
void DeleteAll(Node *head)
{
	Node *cur;
	while(head->link != NULL)
	{
		cur = head;
		head = head->link;
		delete cur;
	}
	
	
}
void DeleteAfter(Node *head)
{
	Node *cur;
	cur -> link = head->link;
	cur = head->link;
    delete cur;
	
}
void DeleteBeffore(Node *head)
{
	Node *cur;
	cur = head->link;
    delete cur;
	
}
int SaskaitamsElem(Node *head)
{
	Node *cur;
	cur = head;
	int sk=0;
	while(head->link != NULL)
	{	
		head = head->link;
		sk++;
	}
	sk++;
	return sk;
}
int main(int argc, char *argv[])
{

    int x;
    Node *head, *m1, *m2, *m3, *m4, *m5;
    head=CreateNode();

    do{
    system("cls");
    cout<<"\n1 saraksta izvads";
    cout<<"\n2 add first";
    cout<<"\n3 Add last";
    cout<<"\n4 DeleteLast";
    cout<<"\n5 Search";
    cout<<"\n6 AddAfter";
    cout<<"\n7 AddBefore";
    cout<<"\n8 DeleteFirst";
    cout<<"\n9 DeleteAfter";
    cout<<"\n10 DeleteBeffore";
    cout<<"\n11 DeleteAll";
    cout<<"\n12 ElementuSK";
    cout<<"\n0 exit:";
    cin>>x;
    switch(x){
     case 1: PrintList(head);system("pause");break;
     case 2: head=addfirst(head);break;
     case 3: AddLast(head);break;
     case 4: DeleteLast(head); break;
     case 5: m1=Search(head); if(m1 != NULL)cout<<"\nTads elements eksiste ";
                                else cout<<"\nTada elementa nav "; 
                            system("pause");
                        break;
     case 6: m2 = Search(head);
             if(m2 != NULL)
             {
                AddAfter(m2);
                cout<<"\n Elementu pievienoja\n";
             }
             else cout<<"\nTada elementa nav ";
             system("pause");
             break;
     case 7:  m3 = Search(head);
             if(m3 != NULL)
             {
                AddBefore(m3);
                cout<<"\n Elementu pievienoja\n";
             }
             else cout<<"\nTada elementa nav ";
             system("pause");
             break;
     case 8: if(head != NULL) 
              {   head = DeleteFirst(head); 
              cout<<"Elements izdzests";
              }
             else  cout<<"Saraksts ir tuks"; break;
     case 9: m4 = Search(head);
	 		 if(m4 != NULL)
	 		 {
			
				 DeleteAfter(m4); cout<<"Elements dzests"; break;
			 }
			 else cout<<"Nav elementu";
	 case 10: m5 = Search(head);
	 		 if(m5 != NULL)
	 		 {
			
				 DeleteBeffore(m5); cout<<"Elements dzests"; break;
			 }
			 else cout<<"Nav elementu";
     case 11: DeleteAll(head); cout<<"Visi elementi ir dzesti"; break;
     case 12: cout<<"Elementu sk="<< SaskaitamsElem(head); cout<<"\n";system("pause"); break;
     case 0: cout<<"beigas";
     default: cout<<"\n nepareizs cipars";
    }
    }while(x!=0);

    cin.get(); cin.get();
    return 0;
}
