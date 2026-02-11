using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using JsonFx.CodeGen;

namespace JsonFx.Serialization.Resolvers
{
	// Token: 0x02000018 RID: 24
	public sealed class FactoryMap : Object
	{
		// Token: 0x0600010E RID: 270 RVA: 0x00007B70 File Offset: 0x00005D70
		// Note: this type is marked as 'beforefieldinit'.
		static FactoryMap()
		{
			Il2CppClassPointerStore<FactoryMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization.Resolvers", "FactoryMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactoryMap>.NativeClassPtr);
			FactoryMap.NativeFieldInfoPtr_ErrorCannotInstantiate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactoryMap>.NativeClassPtr, "ErrorCannotInstantiate");
			FactoryMap.NativeFieldInfoPtr_CollectionCtors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactoryMap>.NativeClassPtr, "CollectionCtors");
			FactoryMap.NativeFieldInfoPtr_Ctor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactoryMap>.NativeClassPtr, "Ctor");
			FactoryMap.NativeFieldInfoPtr_CtorArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactoryMap>.NativeClassPtr, "CtorArgs");
			FactoryMap.NativeFieldInfoPtr_Add = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactoryMap>.NativeClassPtr, "Add");
			FactoryMap.NativeFieldInfoPtr_AddType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactoryMap>.NativeClassPtr, "AddType");
			FactoryMap.NativeFieldInfoPtr_AddRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactoryMap>.NativeClassPtr, "AddRange");
			FactoryMap.NativeFieldInfoPtr_AddRangeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactoryMap>.NativeClassPtr, "AddRangeType");
			FactoryMap.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactoryMap>.NativeClassPtr, 100663416);
			FactoryMap.NativeMethodInfoPtr_get_ArgTypes_Public_get_IEnumerable_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactoryMap>.NativeClassPtr, 100663417);
			FactoryMap.NativeMethodInfoPtr_get_Item_Public_get_FactoryDelegate_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactoryMap>.NativeClassPtr, 100663418);
			FactoryMap.NativeMethodInfoPtr_IsInvalidType_Internal_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactoryMap>.NativeClassPtr, 100663419);
			FactoryMap.NativeMethodInfoPtr_IsImmutableType_Internal_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactoryMap>.NativeClassPtr, 100663420);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00007CA4 File Offset: 0x00005EA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1190741, RefRangeEnd = 1190742, XrefRangeStart = 1190657, XrefRangeEnd = 1190741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FactoryMap(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactoryMap>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FactoryMap.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00007CF0 File Offset: 0x00005EF0
		public unsafe IEnumerable<Type> ArgTypes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190742, XrefRangeEnd = 1190747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FactoryMap.NativeMethodInfoPtr_get_ArgTypes_Public_get_IEnumerable_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x1700004F RID: 79
		public unsafe FactoryDelegate this[Type argType]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1190750, RefRangeEnd = 1190751, XrefRangeStart = 1190747, XrefRangeEnd = 1190750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(argType);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FactoryMap.NativeMethodInfoPtr_get_Item_Public_get_FactoryDelegate_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<FactoryDelegate>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00007D80 File Offset: 0x00005F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190751, XrefRangeEnd = 1190758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInvalidType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FactoryMap.NativeMethodInfoPtr_IsInvalidType_Internal_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00007DC4 File Offset: 0x00005FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190758, XrefRangeEnd = 1190763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsImmutableType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FactoryMap.NativeMethodInfoPtr_IsImmutableType_Internal_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002685 File Offset: 0x00000885
		public FactoryMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00007E08 File Offset: 0x00006008
		// (set) Token: 0x06000116 RID: 278 RVA: 0x0000268E File Offset: 0x0000088E
		public unsafe static string ErrorCannotInstantiate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FactoryMap.NativeFieldInfoPtr_ErrorCannotInstantiate, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FactoryMap.NativeFieldInfoPtr_ErrorCannotInstantiate, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00007E28 File Offset: 0x00006028
		// (set) Token: 0x06000118 RID: 280 RVA: 0x000026A0 File Offset: 0x000008A0
		public unsafe IDictionary<Type, FactoryDelegate> CollectionCtors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryMap.NativeFieldInfoPtr_CollectionCtors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<Type, FactoryDelegate>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryMap.NativeFieldInfoPtr_CollectionCtors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00007E58 File Offset: 0x00006058
		// (set) Token: 0x0600011A RID: 282 RVA: 0x000026BF File Offset: 0x000008BF
		public unsafe FactoryDelegate Ctor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryMap.NativeFieldInfoPtr_Ctor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FactoryDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryMap.NativeFieldInfoPtr_Ctor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00007E88 File Offset: 0x00006088
		// (set) Token: 0x0600011C RID: 284 RVA: 0x000026DE File Offset: 0x000008DE
		public unsafe Il2CppReferenceArray<ParameterInfo> CtorArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryMap.NativeFieldInfoPtr_CtorArgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryMap.NativeFieldInfoPtr_CtorArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00007EB8 File Offset: 0x000060B8
		// (set) Token: 0x0600011E RID: 286 RVA: 0x000026FD File Offset: 0x000008FD
		public unsafe ProxyDelegate Add
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryMap.NativeFieldInfoPtr_Add);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProxyDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryMap.NativeFieldInfoPtr_Add), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00007EE8 File Offset: 0x000060E8
		// (set) Token: 0x06000120 RID: 288 RVA: 0x0000271C File Offset: 0x0000091C
		public unsafe Type AddType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryMap.NativeFieldInfoPtr_AddType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryMap.NativeFieldInfoPtr_AddType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00007F18 File Offset: 0x00006118
		// (set) Token: 0x06000122 RID: 290 RVA: 0x0000273B File Offset: 0x0000093B
		public unsafe ProxyDelegate AddRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryMap.NativeFieldInfoPtr_AddRange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProxyDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryMap.NativeFieldInfoPtr_AddRange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00007F48 File Offset: 0x00006148
		// (set) Token: 0x06000124 RID: 292 RVA: 0x0000275A File Offset: 0x0000095A
		public unsafe Type AddRangeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryMap.NativeFieldInfoPtr_AddRangeType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryMap.NativeFieldInfoPtr_AddRangeType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr_ErrorCannotInstantiate;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr_CollectionCtors;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeFieldInfoPtr_Ctor;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeFieldInfoPtr_CtorArgs;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeFieldInfoPtr_Add;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeFieldInfoPtr_AddType;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeFieldInfoPtr_AddRange;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeFieldInfoPtr_AddRangeType;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgTypes_Public_get_IEnumerable_1_Type_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_FactoryDelegate_Type_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_IsInvalidType_Internal_Static_Boolean_Type_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_IsImmutableType_Internal_Static_Boolean_Type_0;

		// Token: 0x0200003E RID: 62
		[ObfuscatedName("JsonFx.Serialization.Resolvers.FactoryMap+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000330 RID: 816 RVA: 0x0000F7A4 File Offset: 0x0000D9A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FactoryMap.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FactoryMap>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactoryMap.__c>.NativeClassPtr);
				FactoryMap.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactoryMap.__c>.NativeClassPtr, "<>9");
				FactoryMap.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactoryMap.__c>.NativeClassPtr, "<>9__13_0");
				FactoryMap.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactoryMap.__c>.NativeClassPtr, 100663422);
				FactoryMap.__c.NativeMethodInfoPtr__IsInvalidType_b__13_0_Internal_Boolean_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactoryMap.__c>.NativeClassPtr, 100663423);
			}

			// Token: 0x06000331 RID: 817 RVA: 0x0000F820 File Offset: 0x0000DA20
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactoryMap.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FactoryMap.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000332 RID: 818 RVA: 0x0000F85C File Offset: 0x0000DA5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190650, XrefRangeEnd = 1190657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsInvalidType_b__13_0(MemberInfo memberInfo)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FactoryMap.__c.NativeMethodInfoPtr__IsInvalidType_b__13_0_Internal_Boolean_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000333 RID: 819 RVA: 0x0000332E File Offset: 0x0000152E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000DE RID: 222
			// (get) Token: 0x06000334 RID: 820 RVA: 0x0000F8AC File Offset: 0x0000DAAC
			// (set) Token: 0x06000335 RID: 821 RVA: 0x00003337 File Offset: 0x00001537
			public unsafe static FactoryMap.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FactoryMap.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FactoryMap.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FactoryMap.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x06000336 RID: 822 RVA: 0x0000F8D4 File Offset: 0x0000DAD4
			// (set) Token: 0x06000337 RID: 823 RVA: 0x00003349 File Offset: 0x00001549
			public unsafe static Predicate<MemberInfo> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FactoryMap.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<MemberInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FactoryMap.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400021A RID: 538
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400021B RID: 539
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x0400021C RID: 540
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400021D RID: 541
			private static readonly IntPtr NativeMethodInfoPtr__IsInvalidType_b__13_0_Internal_Boolean_MemberInfo_0;
		}
	}
}
