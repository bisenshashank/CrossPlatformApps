package md588e4d7c5b752b752d319df41d2686253;


public class FirstView
	extends md57b8dd31b26d57b878589ceca204f3b49.MvxActivity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Weather.Android.Views.FirstView, Weather.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", FirstView.class, __md_methods);
	}


	public FirstView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == FirstView.class)
			mono.android.TypeManager.Activate ("Weather.Android.Views.FirstView, Weather.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	java.util.ArrayList refList;
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
