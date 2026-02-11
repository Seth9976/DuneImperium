using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200015C RID: 348
	public sealed class WaitForSeconds : YieldInstruction
	{
		// Token: 0x060019E5 RID: 6629 RVA: 0x00079F5C File Offset: 0x0007815C
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForSeconds()
		{
			Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "WaitForSeconds");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr);
			WaitForSeconds.NativeFieldInfoPtr_m_Seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr, "m_Seconds");
			WaitForSeconds.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr, 100666907);
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x00079FB4 File Offset: 0x000781B4
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 673042, RefRangeEnd = 673071, XrefRangeStart = 673041, XrefRangeEnd = 673042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitForSeconds(float seconds)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref seconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForSeconds.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x00009FA1 File Offset: 0x000081A1
		public WaitForSeconds(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x00079FFC File Offset: 0x000781FC
		// (set) Token: 0x060019E9 RID: 6633 RVA: 0x00009FAA File Offset: 0x000081AA
		public unsafe float m_Seconds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSeconds.NativeFieldInfoPtr_m_Seconds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSeconds.NativeFieldInfoPtr_m_Seconds)) = value;
			}
		}

		// Token: 0x04001715 RID: 5909
		private static readonly IntPtr NativeFieldInfoPtr_m_Seconds;

		// Token: 0x04001716 RID: 5910
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
	}
}
