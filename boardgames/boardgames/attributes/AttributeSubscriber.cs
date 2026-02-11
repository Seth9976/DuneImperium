using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.attributes
{
	// Token: 0x02000161 RID: 353
	public class AttributeSubscriber : Subscriber<AttributeDataComponent>
	{
		// Token: 0x060011F1 RID: 4593 RVA: 0x000482D0 File Offset: 0x000464D0
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeSubscriber()
		{
			Il2CppClassPointerStore<AttributeSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes", "AttributeSubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeSubscriber>.NativeClassPtr);
			AttributeSubscriber.NativeFieldInfoPtr_attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeSubscriber>.NativeClassPtr, "attribute");
			AttributeSubscriber.NativeFieldInfoPtr_cachedAttributeVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeSubscriber>.NativeClassPtr, "cachedAttributeVersion");
			AttributeSubscriber.NativeFieldInfoPtr__Attribute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeSubscriber>.NativeClassPtr, "<Attribute>k__BackingField");
			AttributeSubscriber.NativeMethodInfoPtr_get_Attribute_Public_get_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeSubscriber>.NativeClassPtr, 100665931);
			AttributeSubscriber.NativeMethodInfoPtr_set_Attribute_Private_set_Void_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeSubscriber>.NativeClassPtr, 100665932);
			AttributeSubscriber.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeSubscriber>.NativeClassPtr, 100665933);
			AttributeSubscriber.NativeMethodInfoPtr_update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeSubscriber>.NativeClassPtr, 100665934);
			AttributeSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeSubscriber>.NativeClassPtr, 100665935);
			AttributeSubscriber.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeSubscriber>.NativeClassPtr, 100665936);
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x000483B4 File Offset: 0x000465B4
		// (set) Token: 0x060011F3 RID: 4595 RVA: 0x000483F4 File Offset: 0x000465F4
		public unsafe IAttribute Attribute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeSubscriber.NativeMethodInfoPtr_get_Attribute_Public_get_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeSubscriber.NativeMethodInfoPtr_set_Attribute_Private_set_Void_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00048438 File Offset: 0x00046638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000539, XrefRangeEnd = 1000541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeSubscriber.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x00048474 File Offset: 0x00046674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000541, XrefRangeEnd = 1000546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeSubscriber.NativeMethodInfoPtr_update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x000484B0 File Offset: 0x000466B0
		[CallerCount(0)]
		public unsafe virtual void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x000484EC File Offset: 0x000466EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000546, XrefRangeEnd = 1000549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeSubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeSubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeSubscriber.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x0000A62B File Offset: 0x0000882B
		public AttributeSubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060011F9 RID: 4601 RVA: 0x00048528 File Offset: 0x00046728
		// (set) Token: 0x060011FA RID: 4602 RVA: 0x0000A634 File Offset: 0x00008834
		public unsafe int attribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeSubscriber.NativeFieldInfoPtr_attribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeSubscriber.NativeFieldInfoPtr_attribute)) = value;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060011FB RID: 4603 RVA: 0x00048550 File Offset: 0x00046750
		// (set) Token: 0x060011FC RID: 4604 RVA: 0x0000A64F File Offset: 0x0000884F
		public unsafe ulong cachedAttributeVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeSubscriber.NativeFieldInfoPtr_cachedAttributeVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeSubscriber.NativeFieldInfoPtr_cachedAttributeVersion)) = value;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060011FD RID: 4605 RVA: 0x00048578 File Offset: 0x00046778
		// (set) Token: 0x060011FE RID: 4606 RVA: 0x0000A66A File Offset: 0x0000886A
		public unsafe IAttribute _Attribute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeSubscriber.NativeFieldInfoPtr__Attribute_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeSubscriber.NativeFieldInfoPtr__Attribute_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeFieldInfoPtr_attribute;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeFieldInfoPtr_cachedAttributeVersion;

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeFieldInfoPtr__Attribute_k__BackingField;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeMethodInfoPtr_get_Attribute_Public_get_IAttribute_0;

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeMethodInfoPtr_set_Attribute_Private_set_Void_IAttribute_0;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeMethodInfoPtr_update_Protected_Virtual_Void_0;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
