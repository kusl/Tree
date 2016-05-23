#ifndef TTNode_H_
#define TTNode_H_
template <typename Key, typename E>
class TTNode { // 2-3 tree node structure
public:
	E lval; // The node�s left record
	Key lkey; // Left record�s key
	E rval; // The node�s right record
	Key rkey; // Right record�s key
	TTNode* left; // Pointer to left child
	TTNode* center; // Pointer to middle child
	TTNode* right; // Pointer to right child
	TTNode() {
		center = left = right = NULL;
		lkey = rkey = EMPTYKEY;
	}
	TTNode(Key lk, E lv, Key rk, E rv, TTNode<Key, E>* p1,
		TTNode<Key, E>* p2, TTNode<Key, E>* p3) {
		lkey = lk; rkey = rk;
		lval = lv; rval = rv;
		left = p1; center = p2; right = p3;
	}
	~TTNode() { }
	bool isLeaf() { return left == NULL; }
	TTNode<Key, E>* add(TTNode<Key, E>* it);
};
#endif // !TTNode_H_

template<typename Key, typename E>
inline TTNode<Key, E>* TTNode<Key, E>::add(TTNode<Key, E>* it)
{
	return NULL;
}
