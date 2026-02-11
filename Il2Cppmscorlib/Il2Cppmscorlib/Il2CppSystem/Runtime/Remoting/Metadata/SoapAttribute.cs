using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Metadata
{
	// Token: 0x020002DE RID: 734
	public class SoapAttribute : Attribute
	{
		// Token: 0x06002D95 RID: 11669 RVA: 0x000ED270 File Offset: 0x000EB470
		// Note: this type is marked as 'beforefieldinit'.
		static SoapAttribute()
		{
			Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Metadata", "SoapAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr);
			SoapAttribute.NativeFieldInfoPtr__useAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr, "_useAttribute");
			SoapAttribute.NativeFieldInfoPtr_ProtXmlNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr, "ProtXmlNamespace");
			SoapAttribute.NativeFieldInfoPtr_ReflectInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr, "ReflectInfo");
			SoapAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr, 100670607);
			SoapAttribute.NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr, 100670608);
			SoapAttribute.NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr, 100670609);
			SoapAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr, 100670610);
		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x000ED32C File Offset: 0x000EB52C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoapAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06002D97 RID: 11671 RVA: 0x000ED368 File Offset: 0x000EB568
		public unsafe virtual bool UseAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoapAttribute.NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06002D98 RID: 11672 RVA: 0x000ED3B0 File Offset: 0x000EB5B0
		public unsafe virtual string XmlNamespace
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoapAttribute.NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002D99 RID: 11673 RVA: 0x000ED3F4 File Offset: 0x000EB5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetReflectionObject(Object reflectionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reflectionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoapAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D9A RID: 11674 RVA: 0x0000F51F File Offset: 0x0000D71F
		public SoapAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06002D9B RID: 11675 RVA: 0x000ED444 File Offset: 0x000EB644
		// (set) Token: 0x06002D9C RID: 11676 RVA: 0x0000F528 File Offset: 0x0000D728
		public unsafe bool _useAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapAttribute.NativeFieldInfoPtr__useAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapAttribute.NativeFieldInfoPtr__useAttribute)) = value;
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06002D9D RID: 11677 RVA: 0x000ED46C File Offset: 0x000EB66C
		// (set) Token: 0x06002D9E RID: 11678 RVA: 0x0000F543 File Offset: 0x0000D743
		public unsafe string ProtXmlNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapAttribute.NativeFieldInfoPtr_ProtXmlNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapAttribute.NativeFieldInfoPtr_ProtXmlNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06002D9F RID: 11679 RVA: 0x000ED494 File Offset: 0x000EB694
		// (set) Token: 0x06002DA0 RID: 11680 RVA: 0x0000F562 File Offset: 0x0000D762
		public unsafe Object ReflectInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapAttribute.NativeFieldInfoPtr_ReflectInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapAttribute.NativeFieldInfoPtr_ReflectInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400262C RID: 9772
		private static readonly IntPtr NativeFieldInfoPtr__useAttribute;

		// Token: 0x0400262D RID: 9773
		private static readonly IntPtr NativeFieldInfoPtr_ProtXmlNamespace;

		// Token: 0x0400262E RID: 9774
		private static readonly IntPtr NativeFieldInfoPtr_ReflectInfo;

		// Token: 0x0400262F RID: 9775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002630 RID: 9776
		private static readonly IntPtr NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04002631 RID: 9777
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_New_get_String_0;

		// Token: 0x04002632 RID: 9778
		private static readonly IntPtr NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_New_Void_Object_0;
	}
}
