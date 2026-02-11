using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace DG.Tweening.Core
{
	// Token: 0x0200004D RID: 77
	public class SequenceCallback : ABSSequentiable
	{
		// Token: 0x060004A2 RID: 1186 RVA: 0x00003894 File Offset: 0x00001A94
		// Note: this type is marked as 'beforefieldinit'.
		static SequenceCallback()
		{
			Il2CppClassPointerStore<SequenceCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core", "SequenceCallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceCallback>.NativeClassPtr);
			SequenceCallback.NativeMethodInfoPtr__ctor_Public_Void_Single_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCallback>.NativeClassPtr, 100664230);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0001AE24 File Offset: 0x00019024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1133610, RefRangeEnd = 1133611, XrefRangeStart = 1133608, XrefRangeEnd = 1133610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceCallback(float sequencedPosition, TweenCallback callback)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sequencedPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCallback.NativeMethodInfoPtr__ctor_Public_Void_Single_TweenCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x000038CD File Offset: 0x00001ACD
		public SequenceCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_TweenCallback_0;
	}
}
