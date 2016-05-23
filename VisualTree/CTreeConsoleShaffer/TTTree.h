#ifndef TTTree_H_
#define TTTree_H_ 
#include "TTNode.h"
// Find the record that matches a given key value
template <typename Key, typename E>
E TTTree<Key, E>::
findhelp(TTNode<Key, E>* root, Key k) const {
	if (root == NULL) return NULL; // value not found
	if (k == root->lkey) return root->lval;
	if (k == root->rkey) return root->rval;
	if (k < root->lkey) // Go left
		return findhelp(root->left, k);
	else if (root->rkey == EMPTYKEY) // 2 child node
		return findhelp(root->center, k); // Go center
	else if (k < root->rkey)
		return findhelp(root->center, k); // Go center
	else return findhelp(root->right, k); // Go right
}
#endif // !TTTree_H_