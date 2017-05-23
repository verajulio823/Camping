package mono.com.airbnb.lottie.animation;


public class KeyframeAnimation_AnimationListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.airbnb.lottie.animation.KeyframeAnimation.AnimationListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onValueChanged:(Ljava/lang/Object;)V:GetOnValueChanged_Ljava_lang_Object_Handler:Com.Airbnb.Lottie.Animation.KeyframeAnimation/IAnimationListenerInvoker, Lottie\n" +
			"";
		mono.android.Runtime.register ("Com.Airbnb.Lottie.Animation.KeyframeAnimation+IAnimationListenerImplementor, Lottie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", KeyframeAnimation_AnimationListenerImplementor.class, __md_methods);
	}


	public KeyframeAnimation_AnimationListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == KeyframeAnimation_AnimationListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Airbnb.Lottie.Animation.KeyframeAnimation+IAnimationListenerImplementor, Lottie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onValueChanged (java.lang.Object p0)
	{
		n_onValueChanged (p0);
	}

	private native void n_onValueChanged (java.lang.Object p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
