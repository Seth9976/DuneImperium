using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace CanisData.parsers.cell
{
	// Token: 0x02000012 RID: 18
	public class AttributeArrayParser : AttributeCollectionParser
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00005374 File Offset: 0x00003574
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeArrayParser()
		{
			Il2CppClassPointerStore<AttributeArrayParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.parsers.cell", "AttributeArrayParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeArrayParser>.NativeClassPtr);
			AttributeArrayParser.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_List_1_String_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeArrayParser>.NativeClassPtr, 100663356);
			AttributeArrayParser.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_List_1_String_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeArrayParser>.NativeClassPtr, 100663357);
			AttributeArrayParser.NativeMethodInfoPtr_BuildCollectionType_Protected_Virtual_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeArrayParser>.NativeClassPtr, 100663358);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000053E0 File Offset: 0x000035E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222724, XrefRangeEnd = 1222749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeArrayParser(string columnName, string attributeName, string collectionType, List<string> skipTokenList, Dictionary<string, string> replaceMap)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeArrayParser>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(collectionType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skipTokenList);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replaceMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeArrayParser.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_List_1_String_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00005478 File Offset: 0x00003678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeArrayParser(string columnName, string attributeName, string collectionType, string valuePrefix = null, string valueSuffix = null, List<string> skipTokenList = null, Dictionary<string, string> replaceMap = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeArrayParser>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(collectionType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valuePrefix);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueSuffix);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skipTokenList);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replaceMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeArrayParser.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_List_1_String_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00005534 File Offset: 0x00003734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222749, XrefRangeEnd = 1222757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BuildCollectionType(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeArrayParser.NativeMethodInfoPtr_BuildCollectionType_Protected_Virtual_Void_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000244E File Offset: 0x0000064E
		public AttributeArrayParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_List_1_String_Dictionary_2_String_String_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_List_1_String_Dictionary_2_String_String_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_BuildCollectionType_Protected_Virtual_Void_StringBuilder_0;
	}
}
