using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000066 RID: 102
	public class ReflectionObject : Object
	{
		// Token: 0x060008E2 RID: 2274 RVA: 0x0003B5A4 File Offset: 0x000397A4
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionObject()
		{
			Il2CppClassPointerStore<ReflectionObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "ReflectionObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionObject>.NativeClassPtr);
			ReflectionObject.NativeFieldInfoPtr__Creator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionObject>.NativeClassPtr, "<Creator>k__BackingField");
			ReflectionObject.NativeFieldInfoPtr__Members_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionObject>.NativeClassPtr, "<Members>k__BackingField");
			ReflectionObject.NativeMethodInfoPtr_get_Creator_Public_get_ObjectConstructor_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionObject>.NativeClassPtr, 100664993);
			ReflectionObject.NativeMethodInfoPtr_get_Members_Public_get_IDictionary_2_String_ReflectionMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionObject>.NativeClassPtr, 100664994);
			ReflectionObject.NativeMethodInfoPtr__ctor_Private_Void_ObjectConstructor_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionObject>.NativeClassPtr, 100664995);
			ReflectionObject.NativeMethodInfoPtr_GetValue_Public_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionObject>.NativeClassPtr, 100664996);
			ReflectionObject.NativeMethodInfoPtr_SetValue_Public_Void_Object_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionObject>.NativeClassPtr, 100664997);
			ReflectionObject.NativeMethodInfoPtr_GetType_Public_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionObject>.NativeClassPtr, 100664998);
			ReflectionObject.NativeMethodInfoPtr_Create_Public_Static_ReflectionObject_Type_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionObject>.NativeClassPtr, 100664999);
			ReflectionObject.NativeMethodInfoPtr_Create_Public_Static_ReflectionObject_Type_MethodBase_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionObject>.NativeClassPtr, 100665000);
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x0003B69C File Offset: 0x0003989C
		public unsafe ObjectConstructor<Object> Creator
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionObject.NativeMethodInfoPtr_get_Creator_Public_get_ObjectConstructor_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x0003B6DC File Offset: 0x000398DC
		public unsafe IDictionary<string, ReflectionMember> Members
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionObject.NativeMethodInfoPtr_get_Members_Public_get_IDictionary_2_String_ReflectionMember_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, ReflectionMember>>(intPtr3) : null;
			}
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0003B71C File Offset: 0x0003991C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744840, XrefRangeEnd = 744849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionObject(ObjectConstructor<Object> creator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionObject>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(creator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionObject.NativeMethodInfoPtr__ctor_Private_Void_ObjectConstructor_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0003B768 File Offset: 0x00039968
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 744853, RefRangeEnd = 744858, XrefRangeStart = 744849, XrefRangeEnd = 744853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(Object target, string member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionObject.NativeMethodInfoPtr_GetValue_Public_Object_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0003B7CC File Offset: 0x000399CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 744862, RefRangeEnd = 744864, XrefRangeStart = 744858, XrefRangeEnd = 744862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(Object target, string member, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(member);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionObject.NativeMethodInfoPtr_SetValue_Public_Void_Object_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x0003B834 File Offset: 0x00039A34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 744867, RefRangeEnd = 744871, XrefRangeStart = 744864, XrefRangeEnd = 744867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetType(string member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionObject.NativeMethodInfoPtr_GetType_Public_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0003B884 File Offset: 0x00039A84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 744872, RefRangeEnd = 744874, XrefRangeStart = 744871, XrefRangeEnd = 744872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReflectionObject Create(Type t, [Optional] Il2CppStringArray memberNames)
		{
			if (memberNames == null)
			{
				memberNames = new Il2CppStringArray(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionObject.NativeMethodInfoPtr_Create_Public_Static_ReflectionObject_Type_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReflectionObject>(intPtr3) : null;
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0003B8E8 File Offset: 0x00039AE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 744996, RefRangeEnd = 744999, XrefRangeStart = 744874, XrefRangeEnd = 744996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReflectionObject Create(Type t, MethodBase creator, [Optional] Il2CppStringArray memberNames)
		{
			if (memberNames == null)
			{
				memberNames = new Il2CppStringArray(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(creator);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionObject.NativeMethodInfoPtr_Create_Public_Static_ReflectionObject_Type_MethodBase_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReflectionObject>(intPtr3) : null;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00004C98 File Offset: 0x00002E98
		public static ReflectionObject Create(Type t, params string[] memberNames)
		{
			return ReflectionObject.Create(t, new Il2CppStringArray(memberNames));
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00004CA6 File Offset: 0x00002EA6
		public static ReflectionObject Create(Type t, MethodBase creator, params string[] memberNames)
		{
			return ReflectionObject.Create(t, creator, new Il2CppStringArray(memberNames));
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00004CB5 File Offset: 0x00002EB5
		public ReflectionObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x0003B960 File Offset: 0x00039B60
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x00004CBE File Offset: 0x00002EBE
		public unsafe ObjectConstructor<Object> _Creator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionObject.NativeFieldInfoPtr__Creator_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionObject.NativeFieldInfoPtr__Creator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x0003B990 File Offset: 0x00039B90
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x00004CDD File Offset: 0x00002EDD
		public unsafe IDictionary<string, ReflectionMember> _Members_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionObject.NativeFieldInfoPtr__Members_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, ReflectionMember>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionObject.NativeFieldInfoPtr__Members_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeFieldInfoPtr__Creator_k__BackingField;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeFieldInfoPtr__Members_k__BackingField;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr_get_Creator_Public_get_ObjectConstructor_1_Object_0;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeMethodInfoPtr_get_Members_Public_get_IDictionary_2_String_ReflectionMember_0;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_ObjectConstructor_1_Object_0;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Object_String_0;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Object_String_Object_0;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Public_Type_String_0;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ReflectionObject_Type_Il2CppStringArray_0;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ReflectionObject_Type_MethodBase_Il2CppStringArray_0;

		// Token: 0x020001B4 RID: 436
		[ObfuscatedName("Newtonsoft.Json.Utilities.ReflectionObject+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x06001DE2 RID: 7650 RVA: 0x0008AC24 File Offset: 0x00088E24
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<ReflectionObject.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionObject>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionObject.__c__DisplayClass11_0>.NativeClassPtr);
				ReflectionObject.__c__DisplayClass11_0.NativeFieldInfoPtr_ctor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionObject.__c__DisplayClass11_0>.NativeClassPtr, "ctor");
				ReflectionObject.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionObject.__c__DisplayClass11_0>.NativeClassPtr, 100665001);
				ReflectionObject.__c__DisplayClass11_0.NativeMethodInfoPtr__Create_b__0_Internal_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionObject.__c__DisplayClass11_0>.NativeClassPtr, 100665002);
			}

			// Token: 0x06001DE3 RID: 7651 RVA: 0x0008AC8C File Offset: 0x00088E8C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionObject.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionObject.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DE4 RID: 7652 RVA: 0x0008ACC8 File Offset: 0x00088EC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _Create_b__0(Il2CppReferenceArray<Object> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionObject.__c__DisplayClass11_0.NativeMethodInfoPtr__Create_b__0_Internal_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001DE5 RID: 7653 RVA: 0x0000ECD5 File Offset: 0x0000CED5
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700086D RID: 2157
			// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x0008AD18 File Offset: 0x00088F18
			// (set) Token: 0x06001DE7 RID: 7655 RVA: 0x0000ECDE File Offset: 0x0000CEDE
			public unsafe Func<Object> ctor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionObject.__c__DisplayClass11_0.NativeFieldInfoPtr_ctor);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionObject.__c__DisplayClass11_0.NativeFieldInfoPtr_ctor), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015EA RID: 5610
			private static readonly IntPtr NativeFieldInfoPtr_ctor;

			// Token: 0x040015EB RID: 5611
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015EC RID: 5612
			private static readonly IntPtr NativeMethodInfoPtr__Create_b__0_Internal_Object_Il2CppReferenceArray_1_Object_0;
		}

		// Token: 0x020001B5 RID: 437
		[ObfuscatedName("Newtonsoft.Json.Utilities.ReflectionObject+<>c__DisplayClass11_1")]
		public sealed class __c__DisplayClass11_1 : Object
		{
			// Token: 0x06001DE8 RID: 7656 RVA: 0x0008AD48 File Offset: 0x00088F48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_1()
			{
				Il2CppClassPointerStore<ReflectionObject.__c__DisplayClass11_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionObject>.NativeClassPtr, "<>c__DisplayClass11_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionObject.__c__DisplayClass11_1>.NativeClassPtr);
				ReflectionObject.__c__DisplayClass11_1.NativeFieldInfoPtr_call = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionObject.__c__DisplayClass11_1>.NativeClassPtr, "call");
				ReflectionObject.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionObject.__c__DisplayClass11_1>.NativeClassPtr, 100665003);
				ReflectionObject.__c__DisplayClass11_1.NativeMethodInfoPtr__Create_b__1_Internal_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionObject.__c__DisplayClass11_1>.NativeClassPtr, 100665004);
			}

			// Token: 0x06001DE9 RID: 7657 RVA: 0x0008ADB0 File Offset: 0x00088FB0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionObject.__c__DisplayClass11_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionObject.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DEA RID: 7658 RVA: 0x0008ADEC File Offset: 0x00088FEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744824, XrefRangeEnd = 744831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _Create_b__1(Object target)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionObject.__c__DisplayClass11_1.NativeMethodInfoPtr__Create_b__1_Internal_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001DEB RID: 7659 RVA: 0x0000ECFD File Offset: 0x0000CEFD
			public __c__DisplayClass11_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700086E RID: 2158
			// (get) Token: 0x06001DEC RID: 7660 RVA: 0x0008AE3C File Offset: 0x0008903C
			// (set) Token: 0x06001DED RID: 7661 RVA: 0x0000ED06 File Offset: 0x0000CF06
			public unsafe MethodCall<Object, Object> call
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionObject.__c__DisplayClass11_1.NativeFieldInfoPtr_call);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionObject.__c__DisplayClass11_1.NativeFieldInfoPtr_call), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015ED RID: 5613
			private static readonly IntPtr NativeFieldInfoPtr_call;

			// Token: 0x040015EE RID: 5614
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015EF RID: 5615
			private static readonly IntPtr NativeMethodInfoPtr__Create_b__1_Internal_Object_Object_0;
		}

		// Token: 0x020001B6 RID: 438
		[ObfuscatedName("Newtonsoft.Json.Utilities.ReflectionObject+<>c__DisplayClass11_2")]
		public sealed class __c__DisplayClass11_2 : Object
		{
			// Token: 0x06001DEE RID: 7662 RVA: 0x0008AE6C File Offset: 0x0008906C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_2()
			{
				Il2CppClassPointerStore<ReflectionObject.__c__DisplayClass11_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionObject>.NativeClassPtr, "<>c__DisplayClass11_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionObject.__c__DisplayClass11_2>.NativeClassPtr);
				ReflectionObject.__c__DisplayClass11_2.NativeFieldInfoPtr_call = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionObject.__c__DisplayClass11_2>.NativeClassPtr, "call");
				ReflectionObject.__c__DisplayClass11_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionObject.__c__DisplayClass11_2>.NativeClassPtr, 100665005);
				ReflectionObject.__c__DisplayClass11_2.NativeMethodInfoPtr__Create_b__2_Internal_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionObject.__c__DisplayClass11_2>.NativeClassPtr, 100665006);
			}

			// Token: 0x06001DEF RID: 7663 RVA: 0x0008AED4 File Offset: 0x000890D4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionObject.__c__DisplayClass11_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionObject.__c__DisplayClass11_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DF0 RID: 7664 RVA: 0x0008AF10 File Offset: 0x00089110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744831, XrefRangeEnd = 744840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Create_b__2(Object target, Object arg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionObject.__c__DisplayClass11_2.NativeMethodInfoPtr__Create_b__2_Internal_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DF1 RID: 7665 RVA: 0x0000ED25 File Offset: 0x0000CF25
			public __c__DisplayClass11_2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700086F RID: 2159
			// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x0008AF64 File Offset: 0x00089164
			// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x0000ED2E File Offset: 0x0000CF2E
			public unsafe MethodCall<Object, Object> call
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionObject.__c__DisplayClass11_2.NativeFieldInfoPtr_call);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionObject.__c__DisplayClass11_2.NativeFieldInfoPtr_call), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015F0 RID: 5616
			private static readonly IntPtr NativeFieldInfoPtr_call;

			// Token: 0x040015F1 RID: 5617
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015F2 RID: 5618
			private static readonly IntPtr NativeMethodInfoPtr__Create_b__2_Internal_Void_Object_Object_0;
		}
	}
}
