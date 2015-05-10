using UnityEngine;
using System.Collections;

public class fishbowl : MonoBehaviour {

	public enum typ{regular,square};
	public enum lid{none,cork,stun};
	public enum water{regular,inked};
	public enum state{regular,crack,leak};


	public typ _typ;
	public lid _lid;
	public water _water;
	public state _state;
	public bool isSticky;

}
