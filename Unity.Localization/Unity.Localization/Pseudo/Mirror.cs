using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.Pseudo
{
	// Token: 0x020000AA RID: 170
	public class Mirror : Object
	{
		// Token: 0x0600087F RID: 2175 RVA: 0x0002A050 File Offset: 0x00028250
		// Note: this type is marked as 'beforefieldinit'.
		static Mirror()
		{
			Il2CppClassPointerStore<Mirror>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Pseudo", "Mirror");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mirror>.NativeClassPtr);
			Mirror.NativeMethodInfoPtr_Transform_Public_Virtual_Final_New_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mirror>.NativeClassPtr, 100664811);
			Mirror.NativeMethodInfoPtr_MirrorFragment_Private_Void_WritableMessageFragment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mirror>.NativeClassPtr, 100664812);
			Mirror.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mirror>.NativeClassPtr, 100664813);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0002A0BC File Offset: 0x000282BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076791, XrefRangeEnd = 1076809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Transform(Message message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mirror.NativeMethodInfoPtr_Transform_Public_Virtual_Final_New_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0002A100 File Offset: 0x00028300
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1076822, RefRangeEnd = 1076823, XrefRangeStart = 1076809, XrefRangeEnd = 1076822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MirrorFragment(WritableMessageFragment writableMessageFragment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writableMessageFragment);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mirror.NativeMethodInfoPtr_MirrorFragment_Private_Void_WritableMessageFragment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x0002A144 File Offset: 0x00028344
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mirror()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Mirror>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mirror.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x000053D7 File Offset: 0x000035D7
		public Mirror(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr_Transform_Public_Virtual_Final_New_Void_Message_0;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr_MirrorFragment_Private_Void_WritableMessageFragment_0;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
