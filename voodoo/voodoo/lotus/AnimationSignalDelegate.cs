using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace lotus
{
	// Token: 0x02000041 RID: 65
	public class AnimationSignalDelegate : Object
	{
		// Token: 0x06000408 RID: 1032 RVA: 0x000160A0 File Offset: 0x000142A0
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationSignalDelegate()
		{
			Il2CppClassPointerStore<AnimationSignalDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "AnimationSignalDelegate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationSignalDelegate>.NativeClassPtr);
			AnimationSignalDelegate.NativeFieldInfoPtr_signalReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSignalDelegate>.NativeClassPtr, "signalReceived");
			AnimationSignalDelegate.NativeFieldInfoPtr_signal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSignalDelegate>.NativeClassPtr, "signal");
			AnimationSignalDelegate.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignalDelegate>.NativeClassPtr, 100663754);
			AnimationSignalDelegate.NativeMethodInfoPtr_Callback_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignalDelegate>.NativeClassPtr, 100663755);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00016120 File Offset: 0x00014320
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 320067, RefRangeEnd = 320078, XrefRangeStart = 320067, XrefRangeEnd = 320078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationSignalDelegate(string s)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationSignalDelegate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignalDelegate.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0001616C File Offset: 0x0001436C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109600, XrefRangeEnd = 1109601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Callback(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignalDelegate.NativeMethodInfoPtr_Callback_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000041BB File Offset: 0x000023BB
		public AnimationSignalDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x000161B0 File Offset: 0x000143B0
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x000041C4 File Offset: 0x000023C4
		public unsafe bool signalReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignalDelegate.NativeFieldInfoPtr_signalReceived);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignalDelegate.NativeFieldInfoPtr_signalReceived)) = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x000161D8 File Offset: 0x000143D8
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x000041DF File Offset: 0x000023DF
		public unsafe string signal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignalDelegate.NativeFieldInfoPtr_signal);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignalDelegate.NativeFieldInfoPtr_signal), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeFieldInfoPtr_signalReceived;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeFieldInfoPtr_signal;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_Callback_Public_Void_String_0;
	}
}
