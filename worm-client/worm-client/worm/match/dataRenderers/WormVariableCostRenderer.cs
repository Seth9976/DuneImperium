using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lib.canis.boardgames.src.match;
using UnityEngine.Events;
using voodoo;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000172 RID: 370
	public class WormVariableCostRenderer<T> : VersionedDataComponentObserver<T> where T : WormCostData
	{
		// Token: 0x06001095 RID: 4245 RVA: 0x00049BDC File Offset: 0x00047DDC
		// Note: this type is marked as 'beforefieldinit'.
		static WormVariableCostRenderer()
		{
			Il2CppClassPointerStore<WormVariableCostRenderer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormVariableCostRenderer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVariableCostRenderer<T>>.NativeClassPtr);
			WormVariableCostRenderer<T>.NativeFieldInfoPtr_showDefaultCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableCostRenderer<T>>.NativeClassPtr, "showDefaultCost");
			WormVariableCostRenderer<T>.NativeFieldInfoPtr_showReducedCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableCostRenderer<T>>.NativeClassPtr, "showReducedCost");
			WormVariableCostRenderer<T>.NativeFieldInfoPtr_archetypeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableCostRenderer<T>>.NativeClassPtr, "archetypeProvider");
			WormVariableCostRenderer<T>.NativeFieldInfoPtr_lastID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableCostRenderer<T>>.NativeClassPtr, "lastID");
			WormVariableCostRenderer<T>.NativeFieldInfoPtr_defaultCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableCostRenderer<T>>.NativeClassPtr, "defaultCost");
			WormVariableCostRenderer<T>.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableCostRenderer<T>>.NativeClassPtr, 100665600);
			WormVariableCostRenderer<T>.NativeMethodInfoPtr_GetDisplayCost_Protected_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableCostRenderer<T>>.NativeClassPtr, 100665601);
			WormVariableCostRenderer<T>.NativeMethodInfoPtr_OverrideShowDiscount_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableCostRenderer<T>>.NativeClassPtr, 100665602);
			WormVariableCostRenderer<T>.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableCostRenderer<T>>.NativeClassPtr, 100665603);
			WormVariableCostRenderer<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableCostRenderer<T>>.NativeClassPtr, 100665604);
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x00049D10 File Offset: 0x00047F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709762, XrefRangeEnd = 709796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVariableCostRenderer<T>.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x00049D4C File Offset: 0x00047F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetDisplayCost()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVariableCostRenderer<T>.NativeMethodInfoPtr_GetDisplayCost_Protected_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x00049D94 File Offset: 0x00047F94
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool OverrideShowDiscount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVariableCostRenderer<T>.NativeMethodInfoPtr_OverrideShowDiscount_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00049DDC File Offset: 0x00047FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709796, XrefRangeEnd = 709807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVariableCostRenderer<T>.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x00049E18 File Offset: 0x00048018
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 709820, RefRangeEnd = 709822, XrefRangeStart = 709807, XrefRangeEnd = 709820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormVariableCostRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVariableCostRenderer<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableCostRenderer<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x0000ABED File Offset: 0x00008DED
		public WormVariableCostRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x00049E54 File Offset: 0x00048054
		// (set) Token: 0x0600109D RID: 4253 RVA: 0x0000ABF6 File Offset: 0x00008DF6
		public unsafe UnityEvent<string> showDefaultCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableCostRenderer<T>.NativeFieldInfoPtr_showDefaultCost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableCostRenderer<T>.NativeFieldInfoPtr_showDefaultCost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x00049E84 File Offset: 0x00048084
		// (set) Token: 0x0600109F RID: 4255 RVA: 0x0000AC15 File Offset: 0x00008E15
		public unsafe UnityEvent<string> showReducedCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableCostRenderer<T>.NativeFieldInfoPtr_showReducedCost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableCostRenderer<T>.NativeFieldInfoPtr_showReducedCost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x00049EB4 File Offset: 0x000480B4
		// (set) Token: 0x060010A1 RID: 4257 RVA: 0x0000AC34 File Offset: 0x00008E34
		public unsafe ArchetypeProvider archetypeProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableCostRenderer<T>.NativeFieldInfoPtr_archetypeProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableCostRenderer<T>.NativeFieldInfoPtr_archetypeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x00049EE4 File Offset: 0x000480E4
		// (set) Token: 0x060010A3 RID: 4259 RVA: 0x0000AC53 File Offset: 0x00008E53
		public unsafe EntityID lastID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableCostRenderer<T>.NativeFieldInfoPtr_lastID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableCostRenderer<T>.NativeFieldInfoPtr_lastID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x00049F14 File Offset: 0x00048114
		// (set) Token: 0x060010A5 RID: 4261 RVA: 0x0000AC72 File Offset: 0x00008E72
		public Nullable<int> defaultCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableCostRenderer<T>.NativeFieldInfoPtr_defaultCost);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableCostRenderer<T>.NativeFieldInfoPtr_defaultCost), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeFieldInfoPtr_showDefaultCost;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeFieldInfoPtr_showReducedCost;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeFieldInfoPtr_archetypeProvider;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeFieldInfoPtr_lastID;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeFieldInfoPtr_defaultCost;

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayCost_Protected_Virtual_New_Int32_0;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeMethodInfoPtr_OverrideShowDiscount_Protected_Virtual_New_Boolean_0;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
