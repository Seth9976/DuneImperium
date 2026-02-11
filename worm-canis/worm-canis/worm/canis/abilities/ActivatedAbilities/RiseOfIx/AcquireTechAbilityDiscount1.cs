using System;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.abilities.ActivatedAbilities.RiseOfIx
{
	// Token: 0x020004C5 RID: 1221
	public class AcquireTechAbilityDiscount1 : AcquireTechAbility
	{
		// Token: 0x0600370E RID: 14094 RVA: 0x00145BE4 File Offset: 0x00143DE4
		// Note: this type is marked as 'beforefieldinit'.
		static AcquireTechAbilityDiscount1()
		{
			Il2CppClassPointerStore<AcquireTechAbilityDiscount1>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ActivatedAbilities.RiseOfIx", "AcquireTechAbilityDiscount1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AcquireTechAbilityDiscount1>.NativeClassPtr);
			AcquireTechAbilityDiscount1.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechAbilityDiscount1>.NativeClassPtr, "AbilityName");
			AcquireTechAbilityDiscount1.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechAbilityDiscount1>.NativeClassPtr, "AbilityID");
			AcquireTechAbilityDiscount1.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechAbilityDiscount1>.NativeClassPtr, 100680750);
			AcquireTechAbilityDiscount1.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechAbilityDiscount1>.NativeClassPtr, 100680751);
			AcquireTechAbilityDiscount1.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechAbilityDiscount1>.NativeClassPtr, 100680752);
			AcquireTechAbilityDiscount1.NativeMethodInfoPtr_get_TechDiscount_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechAbilityDiscount1>.NativeClassPtr, 100680753);
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x00145C8C File Offset: 0x00143E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246313, XrefRangeEnd = 246317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AcquireTechAbilityDiscount1.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x00145CD8 File Offset: 0x00143ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246317, XrefRangeEnd = 246323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AcquireTechAbilityDiscount1(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AcquireTechAbilityDiscount1>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTechAbilityDiscount1.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x00145D24 File Offset: 0x00143F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246323, XrefRangeEnd = 246327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AcquireTechAbilityDiscount1(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AcquireTechAbilityDiscount1>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTechAbilityDiscount1.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06003712 RID: 14098 RVA: 0x00145D94 File Offset: 0x00143F94
		public unsafe override int TechDiscount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AcquireTechAbilityDiscount1.NativeMethodInfoPtr_get_TechDiscount_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x00012793 File Offset: 0x00010993
		public AcquireTechAbilityDiscount1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06003714 RID: 14100 RVA: 0x00145DDC File Offset: 0x00143FDC
		// (set) Token: 0x06003715 RID: 14101 RVA: 0x0001279C File Offset: 0x0001099C
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AcquireTechAbilityDiscount1.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AcquireTechAbilityDiscount1.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06003716 RID: 14102 RVA: 0x00145DFC File Offset: 0x00143FFC
		// (set) Token: 0x06003717 RID: 14103 RVA: 0x000127AE File Offset: 0x000109AE
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AcquireTechAbilityDiscount1.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AcquireTechAbilityDiscount1.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002403 RID: 9219
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04002404 RID: 9220
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04002405 RID: 9221
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04002406 RID: 9222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04002407 RID: 9223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04002408 RID: 9224
		private static readonly IntPtr NativeMethodInfoPtr_get_TechDiscount_Protected_Virtual_get_Int32_0;
	}
}
