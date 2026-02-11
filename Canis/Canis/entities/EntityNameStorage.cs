using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis.entities
{
	// Token: 0x020000D9 RID: 217
	public static class EntityNameStorage : Object
	{
		// Token: 0x06000A0D RID: 2573 RVA: 0x00044198 File Offset: 0x00042398
		// Note: this type is marked as 'beforefieldinit'.
		static EntityNameStorage()
		{
			Il2CppClassPointerStore<EntityNameStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "EntityNameStorage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityNameStorage>.NativeClassPtr);
			EntityNameStorage.NativeFieldInfoPtr__lookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNameStorage>.NativeClassPtr, "_lookup");
			EntityNameStorage.NativeMethodInfoPtr_Get_Public_Static_IEntityName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNameStorage>.NativeClassPtr, 100665422);
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x000441F0 File Offset: 0x000423F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 565621, RefRangeEnd = 565624, XrefRangeStart = 565608, XrefRangeEnd = 565621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEntityName Get(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNameStorage.NativeMethodInfoPtr_Get_Public_Static_IEntityName_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEntityName>(intPtr3) : null;
			}
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00005BFC File Offset: 0x00003DFC
		public EntityNameStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x00044234 File Offset: 0x00042434
		// (set) Token: 0x06000A11 RID: 2577 RVA: 0x00005C05 File Offset: 0x00003E05
		public unsafe static EntityNameStorage.Lookup _lookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityNameStorage.NativeFieldInfoPtr__lookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameStorage.Lookup>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityNameStorage.NativeFieldInfoPtr__lookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeFieldInfoPtr__lookup;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_IEntityName_String_0;

		// Token: 0x0200031B RID: 795
		public class Lookup : Object
		{
			// Token: 0x06002139 RID: 8505 RVA: 0x00096FD8 File Offset: 0x000951D8
			// Note: this type is marked as 'beforefieldinit'.
			static Lookup()
			{
				Il2CppClassPointerStore<EntityNameStorage.Lookup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityNameStorage>.NativeClassPtr, "Lookup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityNameStorage.Lookup>.NativeClassPtr);
				EntityNameStorage.Lookup.NativeFieldInfoPtr_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNameStorage.Lookup>.NativeClassPtr, "names");
				EntityNameStorage.Lookup.NativeFieldInfoPtr_coreNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNameStorage.Lookup>.NativeClassPtr, "coreNames");
				EntityNameStorage.Lookup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNameStorage.Lookup>.NativeClassPtr, 100665423);
				EntityNameStorage.Lookup.NativeMethodInfoPtr_Fetch_Public_IEntityName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNameStorage.Lookup>.NativeClassPtr, 100665424);
			}

			// Token: 0x0600213A RID: 8506 RVA: 0x00097054 File Offset: 0x00095254
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 565603, RefRangeEnd = 565605, XrefRangeStart = 565483, XrefRangeEnd = 565603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Lookup()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityNameStorage.Lookup>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNameStorage.Lookup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600213B RID: 8507 RVA: 0x00097090 File Offset: 0x00095290
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565605, XrefRangeEnd = 565608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEntityName Fetch(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNameStorage.Lookup.NativeMethodInfoPtr_Fetch_Public_IEntityName_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEntityName>(intPtr3) : null;
				}
			}

			// Token: 0x0600213C RID: 8508 RVA: 0x0000FEF0 File Offset: 0x0000E0F0
			public Lookup(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007FB RID: 2043
			// (get) Token: 0x0600213D RID: 8509 RVA: 0x000970E0 File Offset: 0x000952E0
			// (set) Token: 0x0600213E RID: 8510 RVA: 0x0000FEF9 File Offset: 0x0000E0F9
			public unsafe Dictionary<string, IEntityName> names
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityNameStorage.Lookup.NativeFieldInfoPtr_names);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, IEntityName>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityNameStorage.Lookup.NativeFieldInfoPtr_names), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007FC RID: 2044
			// (get) Token: 0x0600213F RID: 8511 RVA: 0x00097110 File Offset: 0x00095310
			// (set) Token: 0x06002140 RID: 8512 RVA: 0x0000FF18 File Offset: 0x0000E118
			public unsafe Dictionary<string, IEntityName> coreNames
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityNameStorage.Lookup.NativeFieldInfoPtr_coreNames);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, IEntityName>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityNameStorage.Lookup.NativeFieldInfoPtr_coreNames), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014EA RID: 5354
			private static readonly IntPtr NativeFieldInfoPtr_names;

			// Token: 0x040014EB RID: 5355
			private static readonly IntPtr NativeFieldInfoPtr_coreNames;

			// Token: 0x040014EC RID: 5356
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040014ED RID: 5357
			private static readonly IntPtr NativeMethodInfoPtr_Fetch_Public_IEntityName_String_0;

			// Token: 0x0200048C RID: 1164
			[ObfuscatedName("Canis.entities.EntityNameStorage+Lookup+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x060034E2 RID: 13538 RVA: 0x000D684C File Offset: 0x000D4A4C
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<EntityNameStorage.Lookup.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityNameStorage.Lookup>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityNameStorage.Lookup.__c>.NativeClassPtr);
					EntityNameStorage.Lookup.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNameStorage.Lookup.__c>.NativeClassPtr, "<>9");
					EntityNameStorage.Lookup.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNameStorage.Lookup.__c>.NativeClassPtr, "<>9__2_0");
					EntityNameStorage.Lookup.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNameStorage.Lookup.__c>.NativeClassPtr, "<>9__2_1");
					EntityNameStorage.Lookup.__c.NativeFieldInfoPtr___9__2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNameStorage.Lookup.__c>.NativeClassPtr, "<>9__2_2");
					EntityNameStorage.Lookup.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNameStorage.Lookup.__c>.NativeClassPtr, 100665426);
					EntityNameStorage.Lookup.__c.NativeMethodInfoPtr___ctor_b__2_0_Internal_IEnumerable_1_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNameStorage.Lookup.__c>.NativeClassPtr, 100665427);
					EntityNameStorage.Lookup.__c.NativeMethodInfoPtr___ctor_b__2_1_Internal_Boolean_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNameStorage.Lookup.__c>.NativeClassPtr, 100665428);
					EntityNameStorage.Lookup.__c.NativeMethodInfoPtr___ctor_b__2_2_Internal_IEnumerable_1_IEntityName_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNameStorage.Lookup.__c>.NativeClassPtr, 100665429);
				}

				// Token: 0x060034E3 RID: 13539 RVA: 0x000D6918 File Offset: 0x000D4B18
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityNameStorage.Lookup.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNameStorage.Lookup.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060034E4 RID: 13540 RVA: 0x000D6954 File Offset: 0x000D4B54
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565454, XrefRangeEnd = 565463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerable<string> __ctor_b__2_0(Exception x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNameStorage.Lookup.__c.NativeMethodInfoPtr___ctor_b__2_0_Internal_IEnumerable_1_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
					}
				}

				// Token: 0x060034E5 RID: 13541 RVA: 0x000D69A4 File Offset: 0x000D4BA4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565463, XrefRangeEnd = 565470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool __ctor_b__2_1(FieldInfo _)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNameStorage.Lookup.__c.NativeMethodInfoPtr___ctor_b__2_1_Internal_Boolean_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060034E6 RID: 13542 RVA: 0x000D69F4 File Offset: 0x000D4BF4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565470, XrefRangeEnd = 565483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerable<IEntityName> __ctor_b__2_2(FieldInfo _)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNameStorage.Lookup.__c.NativeMethodInfoPtr___ctor_b__2_2_Internal_IEnumerable_1_IEntityName_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEntityName>>(intPtr3) : null;
					}
				}

				// Token: 0x060034E7 RID: 13543 RVA: 0x000198F4 File Offset: 0x00017AF4
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000E2F RID: 3631
				// (get) Token: 0x060034E8 RID: 13544 RVA: 0x000D6A44 File Offset: 0x000D4C44
				// (set) Token: 0x060034E9 RID: 13545 RVA: 0x000198FD File Offset: 0x00017AFD
				public unsafe static EntityNameStorage.Lookup.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(EntityNameStorage.Lookup.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameStorage.Lookup.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(EntityNameStorage.Lookup.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000E30 RID: 3632
				// (get) Token: 0x060034EA RID: 13546 RVA: 0x000D6A6C File Offset: 0x000D4C6C
				// (set) Token: 0x060034EB RID: 13547 RVA: 0x0001990F File Offset: 0x00017B0F
				public unsafe static Func<Exception, IEnumerable<string>> __9__2_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(EntityNameStorage.Lookup.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Exception, IEnumerable<string>>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(EntityNameStorage.Lookup.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000E31 RID: 3633
				// (get) Token: 0x060034EC RID: 13548 RVA: 0x000D6A94 File Offset: 0x000D4C94
				// (set) Token: 0x060034ED RID: 13549 RVA: 0x00019921 File Offset: 0x00017B21
				public unsafe static Func<FieldInfo, bool> __9__2_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(EntityNameStorage.Lookup.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, bool>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(EntityNameStorage.Lookup.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000E32 RID: 3634
				// (get) Token: 0x060034EE RID: 13550 RVA: 0x000D6ABC File Offset: 0x000D4CBC
				// (set) Token: 0x060034EF RID: 13551 RVA: 0x00019933 File Offset: 0x00017B33
				public unsafe static Func<FieldInfo, IEnumerable<IEntityName>> __9__2_2
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(EntityNameStorage.Lookup.__c.NativeFieldInfoPtr___9__2_2, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, IEnumerable<IEntityName>>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(EntityNameStorage.Lookup.__c.NativeFieldInfoPtr___9__2_2, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040020FF RID: 8447
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x04002100 RID: 8448
				private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

				// Token: 0x04002101 RID: 8449
				private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

				// Token: 0x04002102 RID: 8450
				private static readonly IntPtr NativeFieldInfoPtr___9__2_2;

				// Token: 0x04002103 RID: 8451
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04002104 RID: 8452
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__2_0_Internal_IEnumerable_1_String_Exception_0;

				// Token: 0x04002105 RID: 8453
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__2_1_Internal_Boolean_FieldInfo_0;

				// Token: 0x04002106 RID: 8454
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__2_2_Internal_IEnumerable_1_IEntityName_FieldInfo_0;
			}
		}
	}
}
