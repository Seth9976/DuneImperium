using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020002BB RID: 699
	public class ContextCallbackObject : ContextBoundObject
	{
		// Token: 0x06002CBF RID: 11455 RVA: 0x000EA4DC File Offset: 0x000E86DC
		// Note: this type is marked as 'beforefieldinit'.
		static ContextCallbackObject()
		{
			Il2CppClassPointerStore<ContextCallbackObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "ContextCallbackObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextCallbackObject>.NativeClassPtr);
			ContextCallbackObject.NativeMethodInfoPtr_DoCallBack_Public_Void_CrossContextDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextCallbackObject>.NativeClassPtr, 100670504);
			ContextCallbackObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextCallbackObject>.NativeClassPtr, 100670505);
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x000EA534 File Offset: 0x000E8734
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoCallBack(CrossContextDelegate deleg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deleg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextCallbackObject.NativeMethodInfoPtr_DoCallBack_Public_Void_CrossContextDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CC1 RID: 11457 RVA: 0x000EA578 File Offset: 0x000E8778
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextCallbackObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextCallbackObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextCallbackObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x0000EF84 File Offset: 0x0000D184
		public ContextCallbackObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040025B5 RID: 9653
		private static readonly IntPtr NativeMethodInfoPtr_DoCallBack_Public_Void_CrossContextDelegate_0;

		// Token: 0x040025B6 RID: 9654
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
