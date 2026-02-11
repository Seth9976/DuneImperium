using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace zen.src.match.monobehaviours.renderers
{
	// Token: 0x02000079 RID: 121
	public class ChildColliderDisabler : MonoBehaviour
	{
		// Token: 0x06000646 RID: 1606 RVA: 0x0002456C File Offset: 0x0002276C
		// Note: this type is marked as 'beforefieldinit'.
		static ChildColliderDisabler()
		{
			Il2CppClassPointerStore<ChildColliderDisabler>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.monobehaviours.renderers", "ChildColliderDisabler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChildColliderDisabler>.NativeClassPtr);
			ChildColliderDisabler.NativeFieldInfoPtr_enableColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildColliderDisabler>.NativeClassPtr, "enableColliders");
			ChildColliderDisabler.NativeFieldInfoPtr_lastEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildColliderDisabler>.NativeClassPtr, "lastEnabled");
			ChildColliderDisabler.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildColliderDisabler>.NativeClassPtr, 100664276);
			ChildColliderDisabler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildColliderDisabler>.NativeClassPtr, 100664277);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x000245EC File Offset: 0x000227EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988520, XrefRangeEnd = 988525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildColliderDisabler.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00024620 File Offset: 0x00022820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988525, XrefRangeEnd = 988526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChildColliderDisabler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChildColliderDisabler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildColliderDisabler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00004DB3 File Offset: 0x00002FB3
		public ChildColliderDisabler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x0002465C File Offset: 0x0002285C
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x00004DBC File Offset: 0x00002FBC
		public unsafe bool enableColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildColliderDisabler.NativeFieldInfoPtr_enableColliders);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildColliderDisabler.NativeFieldInfoPtr_enableColliders)) = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x00024684 File Offset: 0x00022884
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x00004DD7 File Offset: 0x00002FD7
		public unsafe bool lastEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildColliderDisabler.NativeFieldInfoPtr_lastEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildColliderDisabler.NativeFieldInfoPtr_lastEnabled)) = value;
			}
		}

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeFieldInfoPtr_enableColliders;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeFieldInfoPtr_lastEnabled;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
