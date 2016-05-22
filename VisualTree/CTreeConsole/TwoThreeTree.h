#ifndef TwoThreeTree_H_
#define TwoThreeTree_H_
#include "TwoThreeNode.h"
class TwoThreeTree {
private:
	TwoThreeNode *root;

	// Find the appropriate operation point
	TwoThreeNode* findSpot(TwoThreeNode *node, int data) {
		if (node == NULL) return NULL;

		while (!node->isLeaf()) {
			if (node->key[0] == data || node->key[1] == data)
				return NULL;
			if (node->key[0] == -1 || data < node->key[0])
				node = node->child[0];
			else if (node->key[1] == -1 || data < node->key[1])
				node = node->child[1];
			else
				node = node->child[2];
		}

		if (node->key[0] == data) return NULL;
		return node->parent;
	}

	// Recursively print the subtree starting from the given node
	void print(TwoThreeNode *node, int tabs = 0) {
		for (int i = 0; i < tabs; ++i) {
			std::cout << "\t";
		}

		if (node == NULL) {
			std::cout << "`--> NULL" << std::endl;
			return;
		}

		std::cout << "`--> " << node->GetSiblingNumber()
			<< ": ( " << node->key[0] << ", " << node->key[1] << ")" << std::endl;

		if (!node->isLeaf()) {
			++tabs;
			print(node->child[0], tabs);
			print(node->child[1], tabs);
			print(node->child[2], tabs);
		}
	}

public:
	// Constructor
	TwoThreeTree() {
		root = new TwoThreeNode();
		root->child[0] = new TwoThreeNode();
		root->child[0]->parent = root;
	}

	// Insert
	bool insert(int data) {
		TwoThreeNode *newNode = new TwoThreeNode(data);
		TwoThreeNode *spot = root->child[0];

		if (spot->child[0] == NULL) {
			// First insertion
			newNode->parent = spot;
			spot->child[0] = newNode;
		}
		else {
			spot = findSpot(spot, data);
			if (spot == NULL) return false;

			spot->insert(new TwoThreeNode(data), data);
		}

		return true;
	}

	// Print
	void print() {
		print(root->child[0]);
		std::cout << std::endl;
	}
};
#endif // TwoThreeTree_H_ 
