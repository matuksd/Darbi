#include <cstdlib>
#include <iostream>

using namespace std;

struct Node
{
    int data;
    Node *left, *right;
};

Node *CreateNode()
{
    Node *newNode;
    newNode=new Node;
    cout<<"\nIevadiet skaitli, kuru pievienot:  ";
    cin>>newNode->data;
    newNode->left=NULL;
    newNode->right=NULL;
    return newNode;
}

void PrintTree (Node *cur)
{ 
    if ( ! cur ) return;
    PrintTree (cur->left);
    cout << cur->data << " ";
    PrintTree (cur->right);
}

void AddNode(Node *root) {   
    Node *node = CreateNode();
    
    Node *parent = root;
    bool found = false;
    
    do {
        if (parent->data > node->data) {
            if (parent->left) {
                parent = parent->left;
            } else {
                parent->left = node;
                found = true;
            }
        } else {
            if (parent->right) {
                parent = parent->right;
            } else {
                parent->right = node;
                found = true;
            }
        }
    } while (!found);
    
}
Node *ElementFind(Node *root)
{
int a;
Node *parent = root;
 cout<<"Ievadiet meklejamo sk: "; cin>>a;
 
 if(a == root->data)
 {
 	cout<<"\nElements eksiste ka root";
 	return parent;
 }
 else if (a < root->data)
 {
 	while(a != parent->data)
        {
            parent = parent->left;
        }
        if(a == parent->data)
        {
            cout<<"\nElements eksiste kreisaja puse";
            return parent;
        }
        else cout<<"Elements neeksiste";
 }
 else 
 {
 	 while(a != parent->data)
            {
                parent = parent->right;
            }
            if(a== parent->data)
            {
                cout<<"\nElements eksiste labaja puse";
                return parent;
            }
            else cout<<"Elements neeksiste";
 }

}
Node* findMin(Node* root)
{
    if(root == NULL)
        cout << "\nKoks ir tukss.";
    else
    {
        Node* temp = root;          
        while(temp->left != NULL)   
            temp = temp->left;      
        return temp;                
    }
}
Node* deleteNode(Node* root, Node *find)
{
    if(root == NULL)
        return root;
    else if(find->data < root->data)
    {
	root->left = deleteNode(root->left, find);
	}	
	else if(find->data > root->data) 
    {
	root->right = deleteNode(root->right, find);
    }
    else
    {
        if(root->left == NULL && root->right == NULL)
        {
            delete root;
            root = NULL;
        }
        else if(root->left == NULL)     
        {
            Node* temp = root;      
            root = root->right;         
            delete temp;                
        }
        else if(root->right == NULL)    
        {
            Node* temp = root;          
            root = root->left;          
            delete temp;                
        }
        else
        {
            Node* temp = findMin(root->right);
            root->data = temp->data;            
            root->right = deleteNode(root->right, temp);
        }
    }
    return root;
}

void PostOrder(Node *root)
{
       if(root != NULL)
         {
    		PostOrder(root->left);
       	PostOrder(root->right);
		cout<<root->data<<" ";
 	    }
 	    
}
void CreateTree(Node *root) {
    int n, i;
    cout << "Enter node count: ";
    cin >> n;
    root = CreateNode();
    for (i = 0; i < n; i++) {
        AddNode(root);
    }
    
    
}

int main()
{
    Node *m1,*root = NULL;
    int sk;
    do {
        cout <<"\n0: Exit";
        cout <<"\n1: Print Tree";
        cout <<"\n2: Create root";
        cout <<"\n3: Add node";
        cout <<"\n4: Create Tree";
        cout <<"\n5: FindNode";
        cout <<"\n6: DeleteNode";
        cout <<"\n7: PostOrder pagriesana";
        cout <<"\nOption: ";
        cout <<"\n root:"; 
        if(root != NULL)
        {
        	cout<<root->data;
		}
		else cout<<"Nav izmeidots root";
		cout<<"\n";
    cin >> sk;
    
    switch (sk)
    {
        case 0:
            cout <<"\nExit";
            break;
        case 1:
            cout <<"\nTree: " << endl;
            PrintTree(root);
            break;
        case 2:if (!root) {
                cout <<"\nRoot "; 
                root=CreateNode();
            } 
            else {
                cout <<"\nRoot jau ir!!!";
            }
        case 3:
            cout << "\nAdding node";
            AddNode(root);
            break;
        case 4:
            cout << "\nCreating Tree";
            CreateTree(root);
            break;
        case 5:
			ElementFind(root);
            break;
        	
        case 6:
        	m1 = ElementFind(root);
        	if(root != NULL)
        	{
			deleteNode(root,m1);
			}
        	
			
			else cout<<"Tads elements neeksiste";
		case 7: PostOrder(root);
        default:
            cout << "\nUndefined option";
            break;
            
    }
    } while (sk);

    
    cout <<"\n";
    system("PAUSE");
    return EXIT_SUCCESS;
}
