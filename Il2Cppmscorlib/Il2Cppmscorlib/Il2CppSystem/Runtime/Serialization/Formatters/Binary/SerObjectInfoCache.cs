using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000369 RID: 873
	public sealed class SerObjectInfoCache : Object
	{
		// Token: 0x0600355D RID: 13661 RVA: 0x001089E4 File Offset: 0x00106BE4
		// Note: this type is marked as 'beforefieldinit'.
		static SerObjectInfoCache()
		{
			Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "SerObjectInfoCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr);
			SerObjectInfoCache.NativeFieldInfoPtr_fullTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, "fullTypeName");
			SerObjectInfoCache.NativeFieldInfoPtr_assemblyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, "assemblyString");
			SerObjectInfoCache.NativeFieldInfoPtr_hasTypeForwardedFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, "hasTypeForwardedFrom");
			SerObjectInfoCache.NativeFieldInfoPtr_memberInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, "memberInfos");
			SerObjectInfoCache.NativeFieldInfoPtr_memberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, "memberNames");
			SerObjectInfoCache.NativeFieldInfoPtr_memberTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, "memberTypes");
			SerObjectInfoCache.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, 100671436);
			SerObjectInfoCache.NativeMethodInfoPtr__ctor_Internal_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, 100671437);
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x00108AB4 File Offset: 0x00106CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerObjectInfoCache(string typeName, string assemblyName, bool hasTypeForwardedFrom)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasTypeForwardedFrom;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerObjectInfoCache.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x00108B20 File Offset: 0x00106D20
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1388881, RefRangeEnd = 1388887, XrefRangeStart = 1388874, XrefRangeEnd = 1388881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerObjectInfoCache(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerObjectInfoCache.NativeMethodInfoPtr__ctor_Internal_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x00013057 File Offset: 0x00011257
		public SerObjectInfoCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06003561 RID: 13665 RVA: 0x00108B6C File Offset: 0x00106D6C
		// (set) Token: 0x06003562 RID: 13666 RVA: 0x00013060 File Offset: 0x00011260
		public unsafe string fullTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_fullTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_fullTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06003563 RID: 13667 RVA: 0x00108B94 File Offset: 0x00106D94
		// (set) Token: 0x06003564 RID: 13668 RVA: 0x0001307F File Offset: 0x0001127F
		public unsafe string assemblyString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_assemblyString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_assemblyString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06003565 RID: 13669 RVA: 0x00108BBC File Offset: 0x00106DBC
		// (set) Token: 0x06003566 RID: 13670 RVA: 0x0001309E File Offset: 0x0001129E
		public unsafe bool hasTypeForwardedFrom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_hasTypeForwardedFrom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_hasTypeForwardedFrom)) = value;
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06003567 RID: 13671 RVA: 0x00108BE4 File Offset: 0x00106DE4
		// (set) Token: 0x06003568 RID: 13672 RVA: 0x000130B9 File Offset: 0x000112B9
		public unsafe Il2CppReferenceArray<MemberInfo> memberInfos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_memberInfos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_memberInfos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06003569 RID: 13673 RVA: 0x00108C14 File Offset: 0x00106E14
		// (set) Token: 0x0600356A RID: 13674 RVA: 0x000130D8 File Offset: 0x000112D8
		public unsafe Il2CppStringArray memberNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_memberNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_memberNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x0600356B RID: 13675 RVA: 0x00108C44 File Offset: 0x00106E44
		// (set) Token: 0x0600356C RID: 13676 RVA: 0x000130F7 File Offset: 0x000112F7
		public unsafe Il2CppReferenceArray<Type> memberTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_memberTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_memberTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002BA8 RID: 11176
		private static readonly IntPtr NativeFieldInfoPtr_fullTypeName;

		// Token: 0x04002BA9 RID: 11177
		private static readonly IntPtr NativeFieldInfoPtr_assemblyString;

		// Token: 0x04002BAA RID: 11178
		private static readonly IntPtr NativeFieldInfoPtr_hasTypeForwardedFrom;

		// Token: 0x04002BAB RID: 11179
		private static readonly IntPtr NativeFieldInfoPtr_memberInfos;

		// Token: 0x04002BAC RID: 11180
		private static readonly IntPtr NativeFieldInfoPtr_memberNames;

		// Token: 0x04002BAD RID: 11181
		private static readonly IntPtr NativeFieldInfoPtr_memberTypes;

		// Token: 0x04002BAE RID: 11182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_Boolean_0;

		// Token: 0x04002BAF RID: 11183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_0;
	}
}
