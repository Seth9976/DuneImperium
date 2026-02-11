using System;
using Canis.actions;
using Canis.actions.responseparsers;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.context.targetpickers
{
	// Token: 0x0200011E RID: 286
	public class IntTarget : TargetPicker<int>
	{
		// Token: 0x06000D14 RID: 3348 RVA: 0x000519E8 File Offset: 0x0004FBE8
		// Note: this type is marked as 'beforefieldinit'.
		static IntTarget()
		{
			Il2CppClassPointerStore<IntTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.targetpickers", "IntTarget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntTarget>.NativeClassPtr);
			IntTarget.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntTarget>.NativeClassPtr, "source");
			IntTarget.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntTarget>.NativeClassPtr, "amount");
			IntTarget.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntTarget>.NativeClassPtr, "min");
			IntTarget.NativeFieldInfoPtr_forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntTarget>.NativeClassPtr, "forced");
			IntTarget.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntTarget>.NativeClassPtr, 100666261);
			IntTarget.NativeMethodInfoPtr_WithSource_Public_IntTarget_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntTarget>.NativeClassPtr, 100666262);
			IntTarget.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntTarget>.NativeClassPtr, 100666263);
			IntTarget.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntTarget>.NativeClassPtr, 100666264);
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00051AB8 File Offset: 0x0004FCB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576092, XrefRangeEnd = 576102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntTarget(int amt, Match m, int min = 0, bool forced = true, bool waitForResponse = true)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntTarget>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forced;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitForResponse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntTarget.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00051B3C File Offset: 0x0004FD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576102, XrefRangeEnd = 576103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntTarget WithSource(EntityID eid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntTarget.NativeMethodInfoPtr_WithSource_Public_IntTarget_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntTarget>(intPtr3) : null;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x00051B8C File Offset: 0x0004FD8C
		public unsafe override ResponseParser<int> responseParser
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576103, XrefRangeEnd = 576107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntTarget.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResponseParser<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00051BD8 File Offset: 0x0004FDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576107, XrefRangeEnd = 576132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SelectionRequest PickTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntTarget.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionRequest>(intPtr3) : null;
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00006A3D File Offset: 0x00004C3D
		public IntTarget(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x00051C24 File Offset: 0x0004FE24
		// (set) Token: 0x06000D1B RID: 3355 RVA: 0x00006A46 File Offset: 0x00004C46
		public unsafe EntityID source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntTarget.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntTarget.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000D1C RID: 3356 RVA: 0x00051C54 File Offset: 0x0004FE54
		// (set) Token: 0x06000D1D RID: 3357 RVA: 0x00006A65 File Offset: 0x00004C65
		public unsafe int amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntTarget.NativeFieldInfoPtr_amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntTarget.NativeFieldInfoPtr_amount)) = value;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x00051C7C File Offset: 0x0004FE7C
		// (set) Token: 0x06000D1F RID: 3359 RVA: 0x00006A80 File Offset: 0x00004C80
		public unsafe int min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntTarget.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntTarget.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x00051CA4 File Offset: 0x0004FEA4
		// (set) Token: 0x06000D21 RID: 3361 RVA: 0x00006A9B File Offset: 0x00004C9B
		public unsafe bool forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntTarget.NativeFieldInfoPtr_forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntTarget.NativeFieldInfoPtr_forced)) = value;
			}
		}

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeFieldInfoPtr_amount;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeFieldInfoPtr_forced;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_Int32_Boolean_Boolean_0;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeMethodInfoPtr_WithSource_Public_IntTarget_EntityID_0;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Int32_0;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0;
	}
}
