using System;
using dwd.core.direBytes.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.direBytes
{
	// Token: 0x0200000F RID: 15
	public class DireByteSubpageLinkController : Subscriber<UrlData>
	{
		// Token: 0x060000AD RID: 173 RVA: 0x000055F8 File Offset: 0x000037F8
		// Note: this type is marked as 'beforefieldinit'.
		static DireByteSubpageLinkController()
		{
			Il2CppClassPointerStore<DireByteSubpageLinkController>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes", "DireByteSubpageLinkController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireByteSubpageLinkController>.NativeClassPtr);
			DireByteSubpageLinkController.NativeFieldInfoPtr_hasURLLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteSubpageLinkController>.NativeClassPtr, "hasURLLink");
			DireByteSubpageLinkController.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteSubpageLinkController>.NativeClassPtr, 100663384);
			DireByteSubpageLinkController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteSubpageLinkController>.NativeClassPtr, 100663385);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00005664 File Offset: 0x00003864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234654, XrefRangeEnd = 1234659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DireByteSubpageLinkController.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000056A0 File Offset: 0x000038A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234659, XrefRangeEnd = 1234667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireByteSubpageLinkController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireByteSubpageLinkController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteSubpageLinkController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000256F File Offset: 0x0000076F
		public DireByteSubpageLinkController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x000056DC File Offset: 0x000038DC
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002578 File Offset: 0x00000778
		public unsafe UnityEventBool hasURLLink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteSubpageLinkController.NativeFieldInfoPtr_hasURLLink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEventBool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteSubpageLinkController.NativeFieldInfoPtr_hasURLLink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr_hasURLLink;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
