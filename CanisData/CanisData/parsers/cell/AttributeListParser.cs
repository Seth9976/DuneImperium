using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace CanisData.parsers.cell
{
	// Token: 0x02000011 RID: 17
	public class AttributeListParser : AttributeCollectionParser
	{
		// Token: 0x06000077 RID: 119 RVA: 0x00005210 File Offset: 0x00003410
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeListParser()
		{
			Il2CppClassPointerStore<AttributeListParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.parsers.cell", "AttributeListParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeListParser>.NativeClassPtr);
			AttributeListParser.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_List_1_String_Dictionary_2_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeListParser>.NativeClassPtr, 100663354);
			AttributeListParser.NativeMethodInfoPtr_BuildCollectionType_Protected_Virtual_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeListParser>.NativeClassPtr, 100663355);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00005268 File Offset: 0x00003468
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 1222687, RefRangeEnd = 1222716, XrefRangeStart = 1222662, XrefRangeEnd = 1222687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeListParser(string columnName, string attributeName, string collectionType, List<string> skipTokenList = null, Dictionary<string, string> replaceMap = null, string valuePrefix = null, string valueSuffix = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeListParser>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(collectionType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skipTokenList);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replaceMap);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valuePrefix);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueSuffix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeListParser.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_List_1_String_Dictionary_2_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00005324 File Offset: 0x00003524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222716, XrefRangeEnd = 1222724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BuildCollectionType(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeListParser.NativeMethodInfoPtr_BuildCollectionType_Protected_Virtual_Void_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002445 File Offset: 0x00000645
		public AttributeListParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_List_1_String_Dictionary_2_String_String_String_String_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_BuildCollectionType_Protected_Virtual_Void_StringBuilder_0;
	}
}
