package mono.com.airbnb.lottie.model;


public class LottieComposition_OnCompositionLoadedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.airbnb.lottie.model.LottieComposition.OnCompositionLoadedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCompositionLoaded:(Lcom/airbnb/lottie/model/LottieComposition;)V:GetOnCompositionLoaded_Lcom_airbnb_lottie_model_LottieComposition_Handler:Com.Airbnb.Lottie.Model.LottieComposition/IOnCompositionLoadedListenerInvoker, Lottie\n" +
			"";
		mono.android.Runtime.register ("Com.Airbnb.Lottie.Model.LottieComposition+IOnCompositionLoadedListenerImplementor, Lottie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", LottieComposition_OnCompositionLoadedListenerImplementor.class, __md_methods);
	}


	public LottieComposition_OnCompositionLoadedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == LottieComposition_OnCompositionLoadedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Airbnb.Lottie.Model.LottieComposition+IOnCompositionLoadedListenerImplementor, Lottie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCompositionLoaded (com.airbnb.lottie.model.LottieComposition p0)
	{
		n_onCompositionLoaded (p0);
	}

	private native void n_onCompositionLoaded (com.airbnb.lottie.model.LottieComposition p0);

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
