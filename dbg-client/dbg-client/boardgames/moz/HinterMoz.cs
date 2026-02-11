using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace boardgames.moz
{
	// Token: 0x02000114 RID: 276
	public class HinterMoz : BaseMoz
	{
		// Token: 0x06000C7A RID: 3194 RVA: 0x00044F9C File Offset: 0x0004319C
		// Note: this type is marked as 'beforefieldinit'.
		static HinterMoz()
		{
			Il2CppClassPointerStore<HinterMoz>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "HinterMoz");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HinterMoz>.NativeClassPtr);
			HinterMoz.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HinterMoz>.NativeClassPtr, "animator");
			HinterMoz.NativeFieldInfoPtr_mouseoverName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HinterMoz>.NativeClassPtr, "mouseoverName");
			HinterMoz.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HinterMoz>.NativeClassPtr, 100665119);
			HinterMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HinterMoz>.NativeClassPtr, 100665120);
			HinterMoz.NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HinterMoz>.NativeClassPtr, 100665121);
			HinterMoz.NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HinterMoz>.NativeClassPtr, 100665122);
			HinterMoz.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HinterMoz>.NativeClassPtr, 100665123);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00045058 File Offset: 0x00043258
		[CallerCount(0)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HinterMoz.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0004508C File Offset: 0x0004328C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initMoz(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HinterMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x000450DC File Offset: 0x000432DC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void updateMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HinterMoz.NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00045118 File Offset: 0x00043318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void endMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HinterMoz.NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00045154 File Offset: 0x00043354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509851, XrefRangeEnd = 509856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HinterMoz()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HinterMoz>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HinterMoz.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x000080A3 File Offset: 0x000062A3
		public HinterMoz(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x00045190 File Offset: 0x00043390
		// (set) Token: 0x06000C82 RID: 3202 RVA: 0x000080AC File Offset: 0x000062AC
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HinterMoz.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HinterMoz.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x000451C0 File Offset: 0x000433C0
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x000080CB File Offset: 0x000062CB
		public unsafe string mouseoverName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HinterMoz.NativeFieldInfoPtr_mouseoverName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HinterMoz.NativeFieldInfoPtr_mouseoverName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeFieldInfoPtr_mouseoverName;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
