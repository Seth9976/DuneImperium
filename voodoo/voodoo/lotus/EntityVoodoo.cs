using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x02000069 RID: 105
	public class EntityVoodoo : MonoBehaviour
	{
		// Token: 0x0600062D RID: 1581 RVA: 0x0001DDEC File Offset: 0x0001BFEC
		// Note: this type is marked as 'beforefieldinit'.
		static EntityVoodoo()
		{
			Il2CppClassPointerStore<EntityVoodoo>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "EntityVoodoo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityVoodoo>.NativeClassPtr);
			EntityVoodoo.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVoodoo>.NativeClassPtr, "view");
			EntityVoodoo.NativeFieldInfoPtr_validMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVoodoo>.NativeClassPtr, "validMethods");
			EntityVoodoo.NativeMethodInfoPtr_Init_Public_Void_VoodooView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVoodoo>.NativeClassPtr, 100664149);
			EntityVoodoo.NativeMethodInfoPtr_OnWaypointReached_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVoodoo>.NativeClassPtr, 100664150);
			EntityVoodoo.NativeMethodInfoPtr_GetValidMethods_Public_Virtual_New_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVoodoo>.NativeClassPtr, 100664151);
			EntityVoodoo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVoodoo>.NativeClassPtr, 100664152);
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0001DE94 File Offset: 0x0001C094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(VoodooView v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVoodoo.NativeMethodInfoPtr_Init_Public_Void_VoodooView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0001DED8 File Offset: 0x0001C0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112831, XrefRangeEnd = 1112849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnWaypointReached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityVoodoo.NativeMethodInfoPtr_OnWaypointReached_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0001DF14 File Offset: 0x0001C114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112849, XrefRangeEnd = 1112853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStringArray GetValidMethods()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityVoodoo.NativeMethodInfoPtr_GetValidMethods_Public_Virtual_New_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0001DF60 File Offset: 0x0001C160
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityVoodoo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityVoodoo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVoodoo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x000050B6 File Offset: 0x000032B6
		public EntityVoodoo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x0001DF9C File Offset: 0x0001C19C
		// (set) Token: 0x06000634 RID: 1588 RVA: 0x000050BF File Offset: 0x000032BF
		public unsafe VoodooView view
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVoodoo.NativeFieldInfoPtr_view);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVoodoo.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x0001DFCC File Offset: 0x0001C1CC
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x000050DE File Offset: 0x000032DE
		public unsafe static Il2CppStringArray validMethods
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityVoodoo.NativeFieldInfoPtr_validMethods, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityVoodoo.NativeFieldInfoPtr_validMethods, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeFieldInfoPtr_view;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeFieldInfoPtr_validMethods;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_VoodooView_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_OnWaypointReached_Public_Virtual_New_Void_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_GetValidMethods_Public_Virtual_New_Il2CppStringArray_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
