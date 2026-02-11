using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000142 RID: 322
	public class ImmediateModeException : Exception
	{
		// Token: 0x06001829 RID: 6185 RVA: 0x0000B1F1 File Offset: 0x000093F1
		// Note: this type is marked as 'beforefieldinit'.
		static ImmediateModeException()
		{
			Il2CppClassPointerStore<ImmediateModeException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ImmediateModeException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImmediateModeException>.NativeClassPtr);
			ImmediateModeException.NativeMethodInfoPtr__ctor_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmediateModeException>.NativeClassPtr, 100666878);
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x00072858 File Offset: 0x00070A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320059, XrefRangeEnd = 320065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImmediateModeException(Exception inner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImmediateModeException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImmediateModeException.NativeMethodInfoPtr__ctor_Public_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x0000B22A File Offset: 0x0000942A
		public ImmediateModeException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Exception_0;
	}
}
