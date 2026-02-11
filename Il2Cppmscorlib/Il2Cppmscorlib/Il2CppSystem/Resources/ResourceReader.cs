using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Serialization.Formatters.Binary;

namespace Il2CppSystem.Resources
{
	// Token: 0x020003F1 RID: 1009
	public sealed class ResourceReader : Object
	{
		// Token: 0x06003B1A RID: 15130 RVA: 0x0011C2EC File Offset: 0x0011A4EC
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceReader()
		{
			Il2CppClassPointerStore<ResourceReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "ResourceReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr);
			ResourceReader.NativeFieldInfoPtr__store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_store");
			ResourceReader.NativeFieldInfoPtr__resCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_resCache");
			ResourceReader.NativeFieldInfoPtr__nameSectionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_nameSectionOffset");
			ResourceReader.NativeFieldInfoPtr__dataSectionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_dataSectionOffset");
			ResourceReader.NativeFieldInfoPtr__nameHashes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_nameHashes");
			ResourceReader.NativeFieldInfoPtr__nameHashesPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_nameHashesPtr");
			ResourceReader.NativeFieldInfoPtr__namePositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_namePositions");
			ResourceReader.NativeFieldInfoPtr__namePositionsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_namePositionsPtr");
			ResourceReader.NativeFieldInfoPtr__typeTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_typeTable");
			ResourceReader.NativeFieldInfoPtr__typeNamePositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_typeNamePositions");
			ResourceReader.NativeFieldInfoPtr__objFormatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_objFormatter");
			ResourceReader.NativeFieldInfoPtr__numResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_numResources");
			ResourceReader.NativeFieldInfoPtr__ums = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_ums");
			ResourceReader.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_version");
			ResourceReader.NativeMethodInfoPtr__ctor_Internal_Void_Stream_Dictionary_2_String_ResourceLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672119);
			ResourceReader.NativeMethodInfoPtr_Close_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672120);
			ResourceReader.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672121);
			ResourceReader.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672122);
			ResourceReader.NativeMethodInfoPtr_ReadUnalignedI4_Internal_Static_Int32_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672123);
			ResourceReader.NativeMethodInfoPtr_SkipString_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672124);
			ResourceReader.NativeMethodInfoPtr_GetNameHash_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672125);
			ResourceReader.NativeMethodInfoPtr_GetNamePosition_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672126);
			ResourceReader.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672127);
			ResourceReader.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672128);
			ResourceReader.NativeMethodInfoPtr_GetEnumeratorInternal_Internal_ResourceEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672129);
			ResourceReader.NativeMethodInfoPtr_FindPosForResource_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672130);
			ResourceReader.NativeMethodInfoPtr_CompareStringEqualsName_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672131);
			ResourceReader.NativeMethodInfoPtr_AllocateStringForNameIndex_Private_String_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672132);
			ResourceReader.NativeMethodInfoPtr_GetValueForNameIndex_Private_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672133);
			ResourceReader.NativeMethodInfoPtr_LoadString_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672134);
			ResourceReader.NativeMethodInfoPtr_LoadObject_Internal_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672135);
			ResourceReader.NativeMethodInfoPtr_LoadObject_Internal_Object_Int32_byref_ResourceTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672136);
			ResourceReader.NativeMethodInfoPtr_LoadObjectV1_Internal_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672137);
			ResourceReader.NativeMethodInfoPtr__LoadObjectV1_Private_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672138);
			ResourceReader.NativeMethodInfoPtr_LoadObjectV2_Internal_Object_Int32_byref_ResourceTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672139);
			ResourceReader.NativeMethodInfoPtr__LoadObjectV2_Private_Object_Int32_byref_ResourceTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672140);
			ResourceReader.NativeMethodInfoPtr_DeserializeObject_Private_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672141);
			ResourceReader.NativeMethodInfoPtr_ReadResources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672142);
			ResourceReader.NativeMethodInfoPtr__ReadResources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672143);
			ResourceReader.NativeMethodInfoPtr_FindType_Private_RuntimeType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100672144);
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x0011C63C File Offset: 0x0011A83C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1397660, RefRangeEnd = 1397662, XrefRangeStart = 1397644, XrefRangeEnd = 1397660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceReader(Stream stream, Dictionary<string, ResourceLocator> resCache)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resCache);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr__ctor_Internal_Void_Stream_Dictionary_2_String_ResourceLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B1C RID: 15132 RVA: 0x0011C69C File Offset: 0x0011A89C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1397668, RefRangeEnd = 1397669, XrefRangeStart = 1397662, XrefRangeEnd = 1397668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_Close_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B1D RID: 15133 RVA: 0x0011C6D0 File Offset: 0x0011A8D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1397668, RefRangeEnd = 1397669, XrefRangeStart = 1397668, XrefRangeEnd = 1397669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B1E RID: 15134 RVA: 0x0011C704 File Offset: 0x0011A904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1397669, XrefRangeEnd = 1397675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B1F RID: 15135 RVA: 0x0011C744 File Offset: 0x0011A944
		[CallerCount(0)]
		public unsafe static int ReadUnalignedI4(int* p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_ReadUnalignedI4_Internal_Static_Int32_ptr_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003B20 RID: 15136 RVA: 0x0011C780 File Offset: 0x0011A980
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1397684, RefRangeEnd = 1397687, XrefRangeStart = 1397675, XrefRangeEnd = 1397684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_SkipString_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B21 RID: 15137 RVA: 0x0011C7B4 File Offset: 0x0011A9B4
		[CallerCount(0)]
		public unsafe int GetNameHash(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_GetNameHash_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003B22 RID: 15138 RVA: 0x0011C800 File Offset: 0x0011AA00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1397688, RefRangeEnd = 1397690, XrefRangeStart = 1397687, XrefRangeEnd = 1397688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNamePosition(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_GetNamePosition_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003B23 RID: 15139 RVA: 0x0011C84C File Offset: 0x0011AA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1397690, XrefRangeEnd = 1397695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003B24 RID: 15140 RVA: 0x0011C88C File Offset: 0x0011AA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003B25 RID: 15141 RVA: 0x0011C8CC File Offset: 0x0011AACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1397700, RefRangeEnd = 1397701, XrefRangeStart = 1397695, XrefRangeEnd = 1397700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceReader.ResourceEnumerator GetEnumeratorInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_GetEnumeratorInternal_Internal_ResourceEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceReader.ResourceEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003B26 RID: 15142 RVA: 0x0011C90C File Offset: 0x0011AB0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1397706, RefRangeEnd = 1397707, XrefRangeStart = 1397701, XrefRangeEnd = 1397706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindPosForResource(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_FindPosForResource_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003B27 RID: 15143 RVA: 0x0011C95C File Offset: 0x0011AB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1397707, XrefRangeEnd = 1397715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompareStringEqualsName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_CompareStringEqualsName_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003B28 RID: 15144 RVA: 0x0011C9AC File Offset: 0x0011ABAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1397727, RefRangeEnd = 1397729, XrefRangeStart = 1397715, XrefRangeEnd = 1397727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string AllocateStringForNameIndex(int index, out int dataOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dataOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_AllocateStringForNameIndex_Private_String_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003B29 RID: 15145 RVA: 0x0011CA00 File Offset: 0x0011AC00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1397739, RefRangeEnd = 1397741, XrefRangeStart = 1397729, XrefRangeEnd = 1397739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValueForNameIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_GetValueForNameIndex_Private_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003B2A RID: 15146 RVA: 0x0011CA4C File Offset: 0x0011AC4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1397751, RefRangeEnd = 1397752, XrefRangeStart = 1397741, XrefRangeEnd = 1397751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string LoadString(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_LoadString_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003B2B RID: 15147 RVA: 0x0011CA90 File Offset: 0x0011AC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1397752, XrefRangeEnd = 1397753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object LoadObject(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_LoadObject_Internal_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003B2C RID: 15148 RVA: 0x0011CADC File Offset: 0x0011ACDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1397757, RefRangeEnd = 1397759, XrefRangeStart = 1397753, XrefRangeEnd = 1397757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object LoadObject(int pos, out ResourceTypeCode typeCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &typeCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_LoadObject_Internal_Object_Int32_byref_ResourceTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003B2D RID: 15149 RVA: 0x0011CB38 File Offset: 0x0011AD38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1397760, RefRangeEnd = 1397763, XrefRangeStart = 1397759, XrefRangeEnd = 1397760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object LoadObjectV1(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_LoadObjectV1_Internal_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003B2E RID: 15150 RVA: 0x0011CB84 File Offset: 0x0011AD84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1397872, RefRangeEnd = 1397873, XrefRangeStart = 1397763, XrefRangeEnd = 1397872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _LoadObjectV1(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr__LoadObjectV1_Private_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003B2F RID: 15151 RVA: 0x0011CBD0 File Offset: 0x0011ADD0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1397874, RefRangeEnd = 1397878, XrefRangeStart = 1397873, XrefRangeEnd = 1397874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object LoadObjectV2(int pos, out ResourceTypeCode typeCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &typeCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_LoadObjectV2_Internal_Object_Int32_byref_ResourceTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003B30 RID: 15152 RVA: 0x0011CC2C File Offset: 0x0011AE2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1397901, RefRangeEnd = 1397902, XrefRangeStart = 1397878, XrefRangeEnd = 1397901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _LoadObjectV2(int pos, out ResourceTypeCode typeCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &typeCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr__LoadObjectV2_Private_Object_Int32_byref_ResourceTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003B31 RID: 15153 RVA: 0x0011CC88 File Offset: 0x0011AE88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1397909, RefRangeEnd = 1397910, XrefRangeStart = 1397902, XrefRangeEnd = 1397909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object DeserializeObject(int typeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_DeserializeObject_Private_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003B32 RID: 15154 RVA: 0x0011CCD4 File Offset: 0x0011AED4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1397917, RefRangeEnd = 1397918, XrefRangeStart = 1397910, XrefRangeEnd = 1397917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadResources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_ReadResources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B33 RID: 15155 RVA: 0x0011CD08 File Offset: 0x0011AF08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1397955, RefRangeEnd = 1397956, XrefRangeStart = 1397918, XrefRangeEnd = 1397955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ReadResources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr__ReadResources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B34 RID: 15156 RVA: 0x0011CD3C File Offset: 0x0011AF3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1397974, RefRangeEnd = 1397977, XrefRangeStart = 1397956, XrefRangeEnd = 1397974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType FindType(int typeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_FindType_Private_RuntimeType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
			}
		}

		// Token: 0x06003B35 RID: 15157 RVA: 0x00015FE6 File Offset: 0x000141E6
		public ResourceReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x06003B36 RID: 15158 RVA: 0x0011CD88 File Offset: 0x0011AF88
		// (set) Token: 0x06003B37 RID: 15159 RVA: 0x00015FEF File Offset: 0x000141EF
		public unsafe BinaryReader _store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06003B38 RID: 15160 RVA: 0x0011CDB8 File Offset: 0x0011AFB8
		// (set) Token: 0x06003B39 RID: 15161 RVA: 0x0001600E File Offset: 0x0001420E
		public unsafe Dictionary<string, ResourceLocator> _resCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__resCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ResourceLocator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__resCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06003B3A RID: 15162 RVA: 0x0011CDE8 File Offset: 0x0011AFE8
		// (set) Token: 0x06003B3B RID: 15163 RVA: 0x0001602D File Offset: 0x0001422D
		public unsafe long _nameSectionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__nameSectionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__nameSectionOffset)) = value;
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06003B3C RID: 15164 RVA: 0x0011CE10 File Offset: 0x0011B010
		// (set) Token: 0x06003B3D RID: 15165 RVA: 0x00016048 File Offset: 0x00014248
		public unsafe long _dataSectionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__dataSectionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__dataSectionOffset)) = value;
			}
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06003B3E RID: 15166 RVA: 0x0011CE38 File Offset: 0x0011B038
		// (set) Token: 0x06003B3F RID: 15167 RVA: 0x00016063 File Offset: 0x00014263
		public unsafe Il2CppStructArray<int> _nameHashes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__nameHashes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__nameHashes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06003B40 RID: 15168 RVA: 0x0011CE68 File Offset: 0x0011B068
		// (set) Token: 0x06003B41 RID: 15169 RVA: 0x00016082 File Offset: 0x00014282
		public unsafe int* _nameHashesPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__nameHashesPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__nameHashesPtr)) = value;
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06003B42 RID: 15170 RVA: 0x0011CE8C File Offset: 0x0011B08C
		// (set) Token: 0x06003B43 RID: 15171 RVA: 0x0001609D File Offset: 0x0001429D
		public unsafe Il2CppStructArray<int> _namePositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__namePositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__namePositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06003B44 RID: 15172 RVA: 0x0011CEBC File Offset: 0x0011B0BC
		// (set) Token: 0x06003B45 RID: 15173 RVA: 0x000160BC File Offset: 0x000142BC
		public unsafe int* _namePositionsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__namePositionsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__namePositionsPtr)) = value;
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06003B46 RID: 15174 RVA: 0x0011CEE0 File Offset: 0x0011B0E0
		// (set) Token: 0x06003B47 RID: 15175 RVA: 0x000160D7 File Offset: 0x000142D7
		public unsafe Il2CppReferenceArray<RuntimeType> _typeTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__typeTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RuntimeType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__typeTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06003B48 RID: 15176 RVA: 0x0011CF10 File Offset: 0x0011B110
		// (set) Token: 0x06003B49 RID: 15177 RVA: 0x000160F6 File Offset: 0x000142F6
		public unsafe Il2CppStructArray<int> _typeNamePositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__typeNamePositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__typeNamePositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x06003B4A RID: 15178 RVA: 0x0011CF40 File Offset: 0x0011B140
		// (set) Token: 0x06003B4B RID: 15179 RVA: 0x00016115 File Offset: 0x00014315
		public unsafe BinaryFormatter _objFormatter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__objFormatter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryFormatter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__objFormatter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06003B4C RID: 15180 RVA: 0x0011CF70 File Offset: 0x0011B170
		// (set) Token: 0x06003B4D RID: 15181 RVA: 0x00016134 File Offset: 0x00014334
		public unsafe int _numResources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__numResources);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__numResources)) = value;
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06003B4E RID: 15182 RVA: 0x0011CF98 File Offset: 0x0011B198
		// (set) Token: 0x06003B4F RID: 15183 RVA: 0x0001614F File Offset: 0x0001434F
		public unsafe UnmanagedMemoryStream _ums
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__ums);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnmanagedMemoryStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__ums), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06003B50 RID: 15184 RVA: 0x0011CFC8 File Offset: 0x0011B1C8
		// (set) Token: 0x06003B51 RID: 15185 RVA: 0x0001616E File Offset: 0x0001436E
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x04002FD3 RID: 12243
		private static readonly IntPtr NativeFieldInfoPtr__store;

		// Token: 0x04002FD4 RID: 12244
		private static readonly IntPtr NativeFieldInfoPtr__resCache;

		// Token: 0x04002FD5 RID: 12245
		private static readonly IntPtr NativeFieldInfoPtr__nameSectionOffset;

		// Token: 0x04002FD6 RID: 12246
		private static readonly IntPtr NativeFieldInfoPtr__dataSectionOffset;

		// Token: 0x04002FD7 RID: 12247
		private static readonly IntPtr NativeFieldInfoPtr__nameHashes;

		// Token: 0x04002FD8 RID: 12248
		private static readonly IntPtr NativeFieldInfoPtr__nameHashesPtr;

		// Token: 0x04002FD9 RID: 12249
		private static readonly IntPtr NativeFieldInfoPtr__namePositions;

		// Token: 0x04002FDA RID: 12250
		private static readonly IntPtr NativeFieldInfoPtr__namePositionsPtr;

		// Token: 0x04002FDB RID: 12251
		private static readonly IntPtr NativeFieldInfoPtr__typeTable;

		// Token: 0x04002FDC RID: 12252
		private static readonly IntPtr NativeFieldInfoPtr__typeNamePositions;

		// Token: 0x04002FDD RID: 12253
		private static readonly IntPtr NativeFieldInfoPtr__objFormatter;

		// Token: 0x04002FDE RID: 12254
		private static readonly IntPtr NativeFieldInfoPtr__numResources;

		// Token: 0x04002FDF RID: 12255
		private static readonly IntPtr NativeFieldInfoPtr__ums;

		// Token: 0x04002FE0 RID: 12256
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x04002FE1 RID: 12257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_Dictionary_2_String_ResourceLocator_0;

		// Token: 0x04002FE2 RID: 12258
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002FE3 RID: 12259
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002FE4 RID: 12260
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x04002FE5 RID: 12261
		private static readonly IntPtr NativeMethodInfoPtr_ReadUnalignedI4_Internal_Static_Int32_ptr_Int32_0;

		// Token: 0x04002FE6 RID: 12262
		private static readonly IntPtr NativeMethodInfoPtr_SkipString_Private_Void_0;

		// Token: 0x04002FE7 RID: 12263
		private static readonly IntPtr NativeMethodInfoPtr_GetNameHash_Private_Int32_Int32_0;

		// Token: 0x04002FE8 RID: 12264
		private static readonly IntPtr NativeMethodInfoPtr_GetNamePosition_Private_Int32_Int32_0;

		// Token: 0x04002FE9 RID: 12265
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04002FEA RID: 12266
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x04002FEB RID: 12267
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumeratorInternal_Internal_ResourceEnumerator_0;

		// Token: 0x04002FEC RID: 12268
		private static readonly IntPtr NativeMethodInfoPtr_FindPosForResource_Internal_Int32_String_0;

		// Token: 0x04002FED RID: 12269
		private static readonly IntPtr NativeMethodInfoPtr_CompareStringEqualsName_Private_Boolean_String_0;

		// Token: 0x04002FEE RID: 12270
		private static readonly IntPtr NativeMethodInfoPtr_AllocateStringForNameIndex_Private_String_Int32_byref_Int32_0;

		// Token: 0x04002FEF RID: 12271
		private static readonly IntPtr NativeMethodInfoPtr_GetValueForNameIndex_Private_Object_Int32_0;

		// Token: 0x04002FF0 RID: 12272
		private static readonly IntPtr NativeMethodInfoPtr_LoadString_Internal_String_Int32_0;

		// Token: 0x04002FF1 RID: 12273
		private static readonly IntPtr NativeMethodInfoPtr_LoadObject_Internal_Object_Int32_0;

		// Token: 0x04002FF2 RID: 12274
		private static readonly IntPtr NativeMethodInfoPtr_LoadObject_Internal_Object_Int32_byref_ResourceTypeCode_0;

		// Token: 0x04002FF3 RID: 12275
		private static readonly IntPtr NativeMethodInfoPtr_LoadObjectV1_Internal_Object_Int32_0;

		// Token: 0x04002FF4 RID: 12276
		private static readonly IntPtr NativeMethodInfoPtr__LoadObjectV1_Private_Object_Int32_0;

		// Token: 0x04002FF5 RID: 12277
		private static readonly IntPtr NativeMethodInfoPtr_LoadObjectV2_Internal_Object_Int32_byref_ResourceTypeCode_0;

		// Token: 0x04002FF6 RID: 12278
		private static readonly IntPtr NativeMethodInfoPtr__LoadObjectV2_Private_Object_Int32_byref_ResourceTypeCode_0;

		// Token: 0x04002FF7 RID: 12279
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeObject_Private_Object_Int32_0;

		// Token: 0x04002FF8 RID: 12280
		private static readonly IntPtr NativeMethodInfoPtr_ReadResources_Private_Void_0;

		// Token: 0x04002FF9 RID: 12281
		private static readonly IntPtr NativeMethodInfoPtr__ReadResources_Private_Void_0;

		// Token: 0x04002FFA RID: 12282
		private static readonly IntPtr NativeMethodInfoPtr_FindType_Private_RuntimeType_Int32_0;

		// Token: 0x020006B7 RID: 1719
		public sealed class ResourceEnumerator : Object
		{
			// Token: 0x06005C82 RID: 23682 RVA: 0x001A3C2C File Offset: 0x001A1E2C
			// Note: this type is marked as 'beforefieldinit'.
			static ResourceEnumerator()
			{
				Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "ResourceEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr);
				ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, "_reader");
				ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__currentIsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, "_currentIsValid");
				ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__currentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, "_currentName");
				ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__dataPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, "_dataPosition");
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_ResourceReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100672145);
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100672146);
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100672147);
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100672148);
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_DataPosition_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100672149);
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100672150);
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100672151);
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100672152);
			}

			// Token: 0x06005C83 RID: 23683 RVA: 0x001A3D48 File Offset: 0x001A1F48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1397570, XrefRangeEnd = 1397572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ResourceEnumerator(ResourceReader reader)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_ResourceReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005C84 RID: 23684 RVA: 0x001A3D94 File Offset: 0x001A1F94
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1397572, RefRangeEnd = 1397573, XrefRangeStart = 1397572, XrefRangeEnd = 1397572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170017B1 RID: 6065
			// (get) Token: 0x06005C85 RID: 23685 RVA: 0x001A3DD0 File Offset: 0x001A1FD0
			public unsafe Object Key
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1397596, RefRangeEnd = 1397597, XrefRangeStart = 1397573, XrefRangeEnd = 1397596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170017B2 RID: 6066
			// (get) Token: 0x06005C86 RID: 23686 RVA: 0x001A3E10 File Offset: 0x001A2010
			public unsafe Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1397597, XrefRangeEnd = 1397601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170017B3 RID: 6067
			// (get) Token: 0x06005C87 RID: 23687 RVA: 0x001A3E50 File Offset: 0x001A2050
			public unsafe int DataPosition
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_DataPosition_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170017B4 RID: 6068
			// (get) Token: 0x06005C88 RID: 23688 RVA: 0x001A3E8C File Offset: 0x001A208C
			public unsafe DictionaryEntry Entry
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1397620, RefRangeEnd = 1397621, XrefRangeStart = 1397601, XrefRangeEnd = 1397620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x170017B5 RID: 6069
			// (get) Token: 0x06005C89 RID: 23689 RVA: 0x001A3EC4 File Offset: 0x001A20C4
			public unsafe Object Value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1397621, XrefRangeEnd = 1397644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005C8A RID: 23690 RVA: 0x001A3F04 File Offset: 0x001A2104
			[CallerCount(0)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C8B RID: 23691 RVA: 0x000218B2 File Offset: 0x0001FAB2
			public ResourceEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017AD RID: 6061
			// (get) Token: 0x06005C8C RID: 23692 RVA: 0x001A3F38 File Offset: 0x001A2138
			// (set) Token: 0x06005C8D RID: 23693 RVA: 0x000218BB File Offset: 0x0001FABB
			public unsafe ResourceReader _reader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__reader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__reader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017AE RID: 6062
			// (get) Token: 0x06005C8E RID: 23694 RVA: 0x001A3F68 File Offset: 0x001A2168
			// (set) Token: 0x06005C8F RID: 23695 RVA: 0x000218DA File Offset: 0x0001FADA
			public unsafe bool _currentIsValid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__currentIsValid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__currentIsValid)) = value;
				}
			}

			// Token: 0x170017AF RID: 6063
			// (get) Token: 0x06005C90 RID: 23696 RVA: 0x001A3F90 File Offset: 0x001A2190
			// (set) Token: 0x06005C91 RID: 23697 RVA: 0x000218F5 File Offset: 0x0001FAF5
			public unsafe int _currentName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__currentName);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__currentName)) = value;
				}
			}

			// Token: 0x170017B0 RID: 6064
			// (get) Token: 0x06005C92 RID: 23698 RVA: 0x001A3FB8 File Offset: 0x001A21B8
			// (set) Token: 0x06005C93 RID: 23699 RVA: 0x00021910 File Offset: 0x0001FB10
			public unsafe int _dataPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__dataPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__dataPosition)) = value;
				}
			}

			// Token: 0x04004B2C RID: 19244
			private static readonly IntPtr NativeFieldInfoPtr__reader;

			// Token: 0x04004B2D RID: 19245
			private static readonly IntPtr NativeFieldInfoPtr__currentIsValid;

			// Token: 0x04004B2E RID: 19246
			private static readonly IntPtr NativeFieldInfoPtr__currentName;

			// Token: 0x04004B2F RID: 19247
			private static readonly IntPtr NativeFieldInfoPtr__dataPosition;

			// Token: 0x04004B30 RID: 19248
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ResourceReader_0;

			// Token: 0x04004B31 RID: 19249
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04004B32 RID: 19250
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004B33 RID: 19251
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004B34 RID: 19252
			private static readonly IntPtr NativeMethodInfoPtr_get_DataPosition_Internal_get_Int32_0;

			// Token: 0x04004B35 RID: 19253
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x04004B36 RID: 19254
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004B37 RID: 19255
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}
	}
}
