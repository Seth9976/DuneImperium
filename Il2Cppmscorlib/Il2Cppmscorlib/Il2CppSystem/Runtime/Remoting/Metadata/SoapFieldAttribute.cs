using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Metadata
{
	// Token: 0x020002DF RID: 735
	public sealed class SoapFieldAttribute : SoapAttribute
	{
		// Token: 0x06002DA1 RID: 11681 RVA: 0x000ED4C4 File Offset: 0x000EB6C4
		// Note: this type is marked as 'beforefieldinit'.
		static SoapFieldAttribute()
		{
			Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Metadata", "SoapFieldAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr);
			SoapFieldAttribute.NativeFieldInfoPtr__elementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr, "_elementName");
			SoapFieldAttribute.NativeFieldInfoPtr__isElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr, "_isElement");
			SoapFieldAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr, 100670611);
			SoapFieldAttribute.NativeMethodInfoPtr_get_XmlElementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr, 100670612);
			SoapFieldAttribute.NativeMethodInfoPtr_IsInteropXmlElement_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr, 100670613);
			SoapFieldAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr, 100670614);
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x000ED56C File Offset: 0x000EB76C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoapFieldAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapFieldAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06002DA3 RID: 11683 RVA: 0x000ED5A8 File Offset: 0x000EB7A8
		public unsafe string XmlElementName
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapFieldAttribute.NativeMethodInfoPtr_get_XmlElementName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x000ED5E0 File Offset: 0x000EB7E0
		[CallerCount(0)]
		public unsafe bool IsInteropXmlElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapFieldAttribute.NativeMethodInfoPtr_IsInteropXmlElement_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x000ED61C File Offset: 0x000EB81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382139, XrefRangeEnd = 1382142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetReflectionObject(Object reflectionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reflectionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapFieldAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x0000F581 File Offset: 0x0000D781
		public SoapFieldAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06002DA7 RID: 11687 RVA: 0x000ED660 File Offset: 0x000EB860
		// (set) Token: 0x06002DA8 RID: 11688 RVA: 0x0000F58A File Offset: 0x0000D78A
		public unsafe string _elementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapFieldAttribute.NativeFieldInfoPtr__elementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapFieldAttribute.NativeFieldInfoPtr__elementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06002DA9 RID: 11689 RVA: 0x000ED688 File Offset: 0x000EB888
		// (set) Token: 0x06002DAA RID: 11690 RVA: 0x0000F5A9 File Offset: 0x0000D7A9
		public unsafe bool _isElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapFieldAttribute.NativeFieldInfoPtr__isElement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapFieldAttribute.NativeFieldInfoPtr__isElement)) = value;
			}
		}

		// Token: 0x04002633 RID: 9779
		private static readonly IntPtr NativeFieldInfoPtr__elementName;

		// Token: 0x04002634 RID: 9780
		private static readonly IntPtr NativeFieldInfoPtr__isElement;

		// Token: 0x04002635 RID: 9781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002636 RID: 9782
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlElementName_Public_get_String_0;

		// Token: 0x04002637 RID: 9783
		private static readonly IntPtr NativeMethodInfoPtr_IsInteropXmlElement_Public_Boolean_0;

		// Token: 0x04002638 RID: 9784
		private static readonly IntPtr NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0;
	}
}
