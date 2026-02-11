using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis.attributes
{
	// Token: 0x0200000B RID: 11
	public static class AttributeDefinitions : Object
	{
		// Token: 0x06000041 RID: 65 RVA: 0x0000455C File Offset: 0x0000275C
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeDefinitions()
		{
			Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "AttributeDefinitions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr);
			AttributeDefinitions.NativeFieldInfoPtr__definitionsByName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr, "_definitionsByName");
			AttributeDefinitions.NativeFieldInfoPtr__definitionsByKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr, "_definitionsByKey");
			AttributeDefinitions.NativeMethodInfoPtr_Register_Public_Static_AttributeDefinition_1_T_AttributeDefinition_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr, 100663326);
			AttributeDefinitions.NativeMethodInfoPtr_GetAllDefinitions_Public_Static_IEnumerable_1_IAttributeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr, 100663327);
			AttributeDefinitions.NativeMethodInfoPtr_GetAllDefinitions_Public_Static_IEnumerable_1_AttributeDefinition_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr, 100663328);
			AttributeDefinitions.NativeMethodInfoPtr_GetAssignableToType_Public_Static_IEnumerable_1_IAttributeDefinition_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr, 100663329);
			AttributeDefinitions.NativeMethodInfoPtr_GetDefinition_Public_Static_IAttributeDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr, 100663330);
			AttributeDefinitions.NativeMethodInfoPtr_GetDefinition_Public_Static_IAttributeDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr, 100663331);
			AttributeDefinitions.NativeMethodInfoPtr_TryGetDefinition_Public_Static_Boolean_Int32_byref_IAttributeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr, 100663332);
			AttributeDefinitions.NativeMethodInfoPtr_TryGetDefinition_Public_Static_Boolean_String_byref_IAttributeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr, 100663333);
			AttributeDefinitions.NativeMethodInfoPtr_GetDefinition_Public_Static_AttributeDefinition_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr, 100663334);
			AttributeDefinitions.NativeMethodInfoPtr_GetDefinition_Public_Static_AttributeDefinition_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr, 100663335);
			AttributeDefinitions.NativeMethodInfoPtr_TryGetDefinition_Public_Static_Boolean_Int32_byref_AttributeDefinition_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr, 100663336);
			AttributeDefinitions.NativeMethodInfoPtr_TryGetDefinition_Public_Static_Boolean_String_byref_AttributeDefinition_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr, 100663337);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000046A4 File Offset: 0x000028A4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1215400, RefRangeEnd = 1215406, XrefRangeStart = 1215383, XrefRangeEnd = 1215400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeDefinition<T> Register<T>(AttributeDefinition<T> definition)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDefinitions.MethodInfoStoreGeneric_Register_Public_Static_AttributeDefinition_1_T_AttributeDefinition_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000046E8 File Offset: 0x000028E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215406, XrefRangeEnd = 1215414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IAttributeDefinition> GetAllDefinitions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDefinitions.NativeMethodInfoPtr_GetAllDefinitions_Public_Static_IEnumerable_1_IAttributeDefinition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttributeDefinition>>(intPtr3) : null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000471C File Offset: 0x0000291C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215414, XrefRangeEnd = 1215423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<AttributeDefinition<T>> GetAllDefinitions<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDefinitions.MethodInfoStoreGeneric_GetAllDefinitions_Public_Static_IEnumerable_1_AttributeDefinition_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AttributeDefinition<T>>>(intPtr3) : null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004750 File Offset: 0x00002950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215423, XrefRangeEnd = 1215445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IAttributeDefinition> GetAssignableToType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDefinitions.NativeMethodInfoPtr_GetAssignableToType_Public_Static_IEnumerable_1_IAttributeDefinition_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttributeDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004794 File Offset: 0x00002994
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1215453, RefRangeEnd = 1215455, XrefRangeStart = 1215445, XrefRangeEnd = 1215453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IAttributeDefinition GetDefinition(int key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDefinitions.NativeMethodInfoPtr_GetDefinition_Public_Static_IAttributeDefinition_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttributeDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000047D4 File Offset: 0x000029D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215455, XrefRangeEnd = 1215463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IAttributeDefinition GetDefinition(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDefinitions.NativeMethodInfoPtr_GetDefinition_Public_Static_IAttributeDefinition_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttributeDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004818 File Offset: 0x00002A18
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1215471, RefRangeEnd = 1215479, XrefRangeStart = 1215463, XrefRangeEnd = 1215471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetDefinition(int key, out IAttributeDefinition definition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AttributeDefinitions.NativeMethodInfoPtr_TryGetDefinition_Public_Static_Boolean_Int32_byref_IAttributeDefinition_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			definition = ((intPtr4 == 0) ? null : new IAttributeDefinition(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00004878 File Offset: 0x00002A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215479, XrefRangeEnd = 1215506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetDefinition(string name, out IAttributeDefinition definition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AttributeDefinitions.NativeMethodInfoPtr_TryGetDefinition_Public_Static_Boolean_String_byref_IAttributeDefinition_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			definition = ((intPtr4 == 0) ? null : new IAttributeDefinition(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000048DC File Offset: 0x00002ADC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1215515, RefRangeEnd = 1215529, XrefRangeStart = 1215506, XrefRangeEnd = 1215515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeDefinition<T> GetDefinition<T>(int key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDefinitions.MethodInfoStoreGeneric_GetDefinition_Public_Static_AttributeDefinition_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<T>>(intPtr3) : null;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000491C File Offset: 0x00002B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215529, XrefRangeEnd = 1215538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeDefinition<T> GetDefinition<T>(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDefinitions.MethodInfoStoreGeneric_GetDefinition_Public_Static_AttributeDefinition_1_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<T>>(intPtr3) : null;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004960 File Offset: 0x00002B60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1215548, RefRangeEnd = 1215549, XrefRangeStart = 1215538, XrefRangeEnd = 1215548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetDefinition<T>(int key, out AttributeDefinition<T> typedDefinition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AttributeDefinitions.MethodInfoStoreGeneric_TryGetDefinition_Public_Static_Boolean_Int32_byref_AttributeDefinition_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typedDefinition = ((intPtr4 == 0) ? null : new AttributeDefinition<T>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000049C0 File Offset: 0x00002BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215549, XrefRangeEnd = 1215559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetDefinition<T>(string name, out AttributeDefinition<T> typedDefinition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AttributeDefinitions.MethodInfoStoreGeneric_TryGetDefinition_Public_Static_Boolean_String_byref_AttributeDefinition_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typedDefinition = ((intPtr4 == 0) ? null : new AttributeDefinition<T>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000021F2 File Offset: 0x000003F2
		public AttributeDefinitions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00004A24 File Offset: 0x00002C24
		// (set) Token: 0x06000050 RID: 80 RVA: 0x000021FB File Offset: 0x000003FB
		public unsafe static Dictionary<string, IAttributeDefinition> _definitionsByName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AttributeDefinitions.NativeFieldInfoPtr__definitionsByName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, IAttributeDefinition>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributeDefinitions.NativeFieldInfoPtr__definitionsByName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00004A4C File Offset: 0x00002C4C
		// (set) Token: 0x06000052 RID: 82 RVA: 0x0000220D File Offset: 0x0000040D
		public unsafe static Dictionary<int, IAttributeDefinition> _definitionsByKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AttributeDefinitions.NativeFieldInfoPtr__definitionsByKey, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, IAttributeDefinition>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributeDefinitions.NativeFieldInfoPtr__definitionsByKey, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr__definitionsByName;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr__definitionsByKey;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Static_AttributeDefinition_1_T_AttributeDefinition_1_T_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_GetAllDefinitions_Public_Static_IEnumerable_1_IAttributeDefinition_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_GetAllDefinitions_Public_Static_IEnumerable_1_AttributeDefinition_1_T_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_GetAssignableToType_Public_Static_IEnumerable_1_IAttributeDefinition_Type_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_GetDefinition_Public_Static_IAttributeDefinition_Int32_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_GetDefinition_Public_Static_IAttributeDefinition_String_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_TryGetDefinition_Public_Static_Boolean_Int32_byref_IAttributeDefinition_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_TryGetDefinition_Public_Static_Boolean_String_byref_IAttributeDefinition_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_GetDefinition_Public_Static_AttributeDefinition_1_T_Int32_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_GetDefinition_Public_Static_AttributeDefinition_1_T_String_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_TryGetDefinition_Public_Static_Boolean_Int32_byref_AttributeDefinition_1_T_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_TryGetDefinition_Public_Static_Boolean_String_byref_AttributeDefinition_1_T_0;

		// Token: 0x0200002C RID: 44
		[ObfuscatedName("Canis.attributes.AttributeDefinitions+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x060002E6 RID: 742 RVA: 0x0000DE00 File Offset: 0x0000C000
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<AttributeDefinitions.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeDefinitions.__c__DisplayClass5_0>.NativeClassPtr);
				AttributeDefinitions.__c__DisplayClass5_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDefinitions.__c__DisplayClass5_0>.NativeClassPtr, "type");
				AttributeDefinitions.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinitions.__c__DisplayClass5_0>.NativeClassPtr, 100663339);
				AttributeDefinitions.__c__DisplayClass5_0.NativeMethodInfoPtr__GetAssignableToType_b__0_Internal_Boolean_IAttributeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinitions.__c__DisplayClass5_0>.NativeClassPtr, 100663340);
			}

			// Token: 0x060002E7 RID: 743 RVA: 0x0000DE68 File Offset: 0x0000C068
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeDefinitions.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDefinitions.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002E8 RID: 744 RVA: 0x0000DEA4 File Offset: 0x0000C0A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215372, XrefRangeEnd = 1215383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAssignableToType_b__0(IAttributeDefinition definition)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDefinitions.__c__DisplayClass5_0.NativeMethodInfoPtr__GetAssignableToType_b__0_Internal_Boolean_IAttributeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060002E9 RID: 745 RVA: 0x000031E3 File Offset: 0x000013E3
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x060002EA RID: 746 RVA: 0x0000DEF4 File Offset: 0x0000C0F4
			// (set) Token: 0x060002EB RID: 747 RVA: 0x000031EC File Offset: 0x000013EC
			public unsafe Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeDefinitions.__c__DisplayClass5_0.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeDefinitions.__c__DisplayClass5_0.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001D2 RID: 466
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x040001D3 RID: 467
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001D4 RID: 468
			private static readonly IntPtr NativeMethodInfoPtr__GetAssignableToType_b__0_Internal_Boolean_IAttributeDefinition_0;
		}

		// Token: 0x0200002D RID: 45
		private sealed class MethodInfoStoreGeneric_Register_Public_Static_AttributeDefinition_1_T_AttributeDefinition_1_T_0<T>
		{
			// Token: 0x040001D5 RID: 469
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AttributeDefinitions.NativeMethodInfoPtr_Register_Public_Static_AttributeDefinition_1_T_AttributeDefinition_1_T_0, Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200002E RID: 46
		private sealed class MethodInfoStoreGeneric_GetAllDefinitions_Public_Static_IEnumerable_1_AttributeDefinition_1_T_0<T>
		{
			// Token: 0x040001D6 RID: 470
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AttributeDefinitions.NativeMethodInfoPtr_GetAllDefinitions_Public_Static_IEnumerable_1_AttributeDefinition_1_T_0, Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200002F RID: 47
		private sealed class MethodInfoStoreGeneric_GetDefinition_Public_Static_AttributeDefinition_1_T_Int32_0<T>
		{
			// Token: 0x040001D7 RID: 471
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AttributeDefinitions.NativeMethodInfoPtr_GetDefinition_Public_Static_AttributeDefinition_1_T_Int32_0, Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000030 RID: 48
		private sealed class MethodInfoStoreGeneric_GetDefinition_Public_Static_AttributeDefinition_1_T_String_0<T>
		{
			// Token: 0x040001D8 RID: 472
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AttributeDefinitions.NativeMethodInfoPtr_GetDefinition_Public_Static_AttributeDefinition_1_T_String_0, Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000031 RID: 49
		private sealed class MethodInfoStoreGeneric_TryGetDefinition_Public_Static_Boolean_Int32_byref_AttributeDefinition_1_T_0<T>
		{
			// Token: 0x040001D9 RID: 473
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AttributeDefinitions.NativeMethodInfoPtr_TryGetDefinition_Public_Static_Boolean_Int32_byref_AttributeDefinition_1_T_0, Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000032 RID: 50
		private sealed class MethodInfoStoreGeneric_TryGetDefinition_Public_Static_Boolean_String_byref_AttributeDefinition_1_T_0<T>
		{
			// Token: 0x040001DA RID: 474
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AttributeDefinitions.NativeMethodInfoPtr_TryGetDefinition_Public_Static_Boolean_String_byref_AttributeDefinition_1_T_0, Il2CppClassPointerStore<AttributeDefinitions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
