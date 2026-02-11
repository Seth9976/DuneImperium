using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000107 RID: 263
	public class AutoValidator : BaseValidator
	{
		// Token: 0x0600179E RID: 6046 RVA: 0x0007B1A8 File Offset: 0x000793A8
		// Note: this type is marked as 'beforefieldinit'.
		static AutoValidator()
		{
			Il2CppClassPointerStore<AutoValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "AutoValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoValidator>.NativeClassPtr);
			AutoValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoValidator>.NativeClassPtr, 100666988);
			AutoValidator.NativeMethodInfoPtr_get_PreserveWhitespace_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoValidator>.NativeClassPtr, 100666989);
			AutoValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoValidator>.NativeClassPtr, 100666990);
			AutoValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoValidator>.NativeClassPtr, 100666991);
			AutoValidator.NativeMethodInfoPtr_FindId_Public_Virtual_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoValidator>.NativeClassPtr, 100666992);
			AutoValidator.NativeMethodInfoPtr_DetectValidationType_Private_ValidationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoValidator>.NativeClassPtr, 100666993);
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x0007B250 File Offset: 0x00079450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390820, XrefRangeEnd = 390826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoValidator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaCollection);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandling);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060017A0 RID: 6048 RVA: 0x0007B2C0 File Offset: 0x000794C0
		public unsafe override bool PreserveWhitespace
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoValidator.NativeMethodInfoPtr_get_PreserveWhitespace_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x0007B308 File Offset: 0x00079508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390826, XrefRangeEnd = 390833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x0007B344 File Offset: 0x00079544
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CompleteValidation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x0007B380 File Offset: 0x00079580
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object FindId(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoValidator.NativeMethodInfoPtr_FindId_Public_Virtual_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x0007B3DC File Offset: 0x000795DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390851, RefRangeEnd = 390852, XrefRangeStart = 390833, XrefRangeEnd = 390851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidationType DetectValidationType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoValidator.NativeMethodInfoPtr_DetectValidationType_Private_ValidationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x0000A18B File Offset: 0x0000838B
		public AutoValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001290 RID: 4752
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_0;

		// Token: 0x04001291 RID: 4753
		private static readonly IntPtr NativeMethodInfoPtr_get_PreserveWhitespace_Public_Virtual_get_Boolean_0;

		// Token: 0x04001292 RID: 4754
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Virtual_Void_0;

		// Token: 0x04001293 RID: 4755
		private static readonly IntPtr NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Void_0;

		// Token: 0x04001294 RID: 4756
		private static readonly IntPtr NativeMethodInfoPtr_FindId_Public_Virtual_Object_String_0;

		// Token: 0x04001295 RID: 4757
		private static readonly IntPtr NativeMethodInfoPtr_DetectValidationType_Private_ValidationType_0;
	}
}
