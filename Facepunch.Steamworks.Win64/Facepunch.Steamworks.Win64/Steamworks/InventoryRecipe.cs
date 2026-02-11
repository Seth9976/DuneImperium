using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020000BD RID: 189
	public sealed class InventoryRecipe : ValueType
	{
		// Token: 0x06000C4A RID: 3146 RVA: 0x000523A4 File Offset: 0x000505A4
		// Note: this type is marked as 'beforefieldinit'.
		static InventoryRecipe()
		{
			Il2CppClassPointerStore<InventoryRecipe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "InventoryRecipe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryRecipe>.NativeClassPtr);
			InventoryRecipe.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryRecipe>.NativeClassPtr, "Result");
			InventoryRecipe.NativeFieldInfoPtr_Ingredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryRecipe>.NativeClassPtr, "Ingredients");
			InventoryRecipe.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryRecipe>.NativeClassPtr, "Source");
			InventoryRecipe.NativeMethodInfoPtr_FromString_Internal_Static_InventoryRecipe_String_InventoryDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryRecipe>.NativeClassPtr, 100666342);
			InventoryRecipe.NativeMethodInfoPtr_ContainsIngredient_Internal_Boolean_InventoryDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryRecipe>.NativeClassPtr, 100666343);
			InventoryRecipe.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InventoryRecipe_InventoryRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryRecipe>.NativeClassPtr, 100666344);
			InventoryRecipe.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InventoryRecipe_InventoryRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryRecipe>.NativeClassPtr, 100666345);
			InventoryRecipe.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryRecipe>.NativeClassPtr, 100666346);
			InventoryRecipe.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryRecipe>.NativeClassPtr, 100666347);
			InventoryRecipe.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InventoryRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryRecipe>.NativeClassPtr, 100666348);
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x0005249C File Offset: 0x0005069C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 947089, RefRangeEnd = 947090, XrefRangeStart = 947044, XrefRangeEnd = 947089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InventoryRecipe FromString(string part, InventoryDef Result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(part);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(Result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryRecipe.NativeMethodInfoPtr_FromString_Internal_Static_InventoryRecipe_String_InventoryDef_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new InventoryRecipe(intPtr);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x000524EC File Offset: 0x000506EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 947105, RefRangeEnd = 947106, XrefRangeStart = 947090, XrefRangeEnd = 947105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsIngredient(InventoryDef inventoryDef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inventoryDef);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryRecipe.NativeMethodInfoPtr_ContainsIngredient_Internal_Boolean_InventoryDef_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00052540 File Offset: 0x00050740
		[CallerCount(0)]
		public unsafe static bool operator ==(InventoryRecipe a, InventoryRecipe b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryRecipe.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InventoryRecipe_InventoryRecipe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x000525A0 File Offset: 0x000507A0
		[CallerCount(0)]
		public unsafe static bool operator !=(InventoryRecipe a, InventoryRecipe b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryRecipe.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InventoryRecipe_InventoryRecipe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00052600 File Offset: 0x00050800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947106, XrefRangeEnd = 947109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryRecipe.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00052654 File Offset: 0x00050854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryRecipe.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00052698 File Offset: 0x00050898
		[CallerCount(0)]
		public unsafe bool Equals(InventoryRecipe p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(p));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryRecipe.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InventoryRecipe_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x0000300D File Offset: 0x0000120D
		public InventoryRecipe(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00003016 File Offset: 0x00001216
		public InventoryRecipe()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryRecipe>.NativeClassPtr))
		{
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x000526F0 File Offset: 0x000508F0
		// (set) Token: 0x06000C55 RID: 3157 RVA: 0x00003028 File Offset: 0x00001228
		public unsafe InventoryDef Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryRecipe.NativeFieldInfoPtr_Result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InventoryDef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryRecipe.NativeFieldInfoPtr_Result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x00052720 File Offset: 0x00050920
		// (set) Token: 0x06000C57 RID: 3159 RVA: 0x00003047 File Offset: 0x00001247
		public unsafe Il2CppReferenceArray<InventoryRecipe.Ingredient> Ingredients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryRecipe.NativeFieldInfoPtr_Ingredients);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InventoryRecipe.Ingredient>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryRecipe.NativeFieldInfoPtr_Ingredients), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x00052750 File Offset: 0x00050950
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x00003066 File Offset: 0x00001266
		public unsafe string Source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryRecipe.NativeFieldInfoPtr_Source);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryRecipe.NativeFieldInfoPtr_Source), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040012ED RID: 4845
		private static readonly IntPtr NativeFieldInfoPtr_Ingredients;

		// Token: 0x040012EE RID: 4846
		private static readonly IntPtr NativeFieldInfoPtr_Source;

		// Token: 0x040012EF RID: 4847
		private static readonly IntPtr NativeMethodInfoPtr_FromString_Internal_Static_InventoryRecipe_String_InventoryDef_0;

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeMethodInfoPtr_ContainsIngredient_Internal_Boolean_InventoryDef_0;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InventoryRecipe_InventoryRecipe_0;

		// Token: 0x040012F2 RID: 4850
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InventoryRecipe_InventoryRecipe_0;

		// Token: 0x040012F3 RID: 4851
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040012F4 RID: 4852
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040012F5 RID: 4853
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InventoryRecipe_0;

		// Token: 0x0200027E RID: 638
		public sealed class Ingredient : ValueType
		{
			// Token: 0x06002060 RID: 8288 RVA: 0x0008EC9C File Offset: 0x0008CE9C
			// Note: this type is marked as 'beforefieldinit'.
			static Ingredient()
			{
				Il2CppClassPointerStore<InventoryRecipe.Ingredient>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryRecipe>.NativeClassPtr, "Ingredient");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryRecipe.Ingredient>.NativeClassPtr);
				InventoryRecipe.Ingredient.NativeFieldInfoPtr_DefinitionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryRecipe.Ingredient>.NativeClassPtr, "DefinitionId");
				InventoryRecipe.Ingredient.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryRecipe.Ingredient>.NativeClassPtr, "Definition");
				InventoryRecipe.Ingredient.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryRecipe.Ingredient>.NativeClassPtr, "Count");
				InventoryRecipe.Ingredient.NativeMethodInfoPtr_FromString_Internal_Static_Ingredient_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryRecipe.Ingredient>.NativeClassPtr, 100666349);
			}

			// Token: 0x06002061 RID: 8289 RVA: 0x0008ED18 File Offset: 0x0008CF18
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 947042, RefRangeEnd = 947043, XrefRangeStart = 947031, XrefRangeEnd = 947042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static InventoryRecipe.Ingredient FromString(string part)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(part);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryRecipe.Ingredient.NativeMethodInfoPtr_FromString_Internal_Static_Ingredient_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new InventoryRecipe.Ingredient(intPtr);
				}
			}

			// Token: 0x06002062 RID: 8290 RVA: 0x0000C5AE File Offset: 0x0000A7AE
			public Ingredient(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002063 RID: 8291 RVA: 0x0000C5B7 File Offset: 0x0000A7B7
			public Ingredient()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryRecipe.Ingredient>.NativeClassPtr))
			{
			}

			// Token: 0x17000856 RID: 2134
			// (get) Token: 0x06002064 RID: 8292 RVA: 0x0008ED54 File Offset: 0x0008CF54
			// (set) Token: 0x06002065 RID: 8293 RVA: 0x0000C5C9 File Offset: 0x0000A7C9
			public unsafe int DefinitionId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryRecipe.Ingredient.NativeFieldInfoPtr_DefinitionId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryRecipe.Ingredient.NativeFieldInfoPtr_DefinitionId)) = value;
				}
			}

			// Token: 0x17000857 RID: 2135
			// (get) Token: 0x06002066 RID: 8294 RVA: 0x0008ED7C File Offset: 0x0008CF7C
			// (set) Token: 0x06002067 RID: 8295 RVA: 0x0000C5E4 File Offset: 0x0000A7E4
			public unsafe InventoryDef Definition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryRecipe.Ingredient.NativeFieldInfoPtr_Definition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InventoryDef>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryRecipe.Ingredient.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000858 RID: 2136
			// (get) Token: 0x06002068 RID: 8296 RVA: 0x0008EDAC File Offset: 0x0008CFAC
			// (set) Token: 0x06002069 RID: 8297 RVA: 0x0000C603 File Offset: 0x0000A803
			public unsafe int Count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryRecipe.Ingredient.NativeFieldInfoPtr_Count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryRecipe.Ingredient.NativeFieldInfoPtr_Count)) = value;
				}
			}

			// Token: 0x040022C2 RID: 8898
			private static readonly IntPtr NativeFieldInfoPtr_DefinitionId;

			// Token: 0x040022C3 RID: 8899
			private static readonly IntPtr NativeFieldInfoPtr_Definition;

			// Token: 0x040022C4 RID: 8900
			private static readonly IntPtr NativeFieldInfoPtr_Count;

			// Token: 0x040022C5 RID: 8901
			private static readonly IntPtr NativeMethodInfoPtr_FromString_Internal_Static_Ingredient_String_0;
		}

		// Token: 0x0200027F RID: 639
		[ObfuscatedName("Steamworks.InventoryRecipe+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600206A RID: 8298 RVA: 0x0008EDD4 File Offset: 0x0008CFD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<InventoryRecipe.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryRecipe>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryRecipe.__c>.NativeClassPtr);
				InventoryRecipe.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryRecipe.__c>.NativeClassPtr, "<>9");
				InventoryRecipe.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryRecipe.__c>.NativeClassPtr, "<>9__4_0");
				InventoryRecipe.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryRecipe.__c>.NativeClassPtr, "<>9__4_1");
				InventoryRecipe.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryRecipe.__c>.NativeClassPtr, 100666351);
				InventoryRecipe.__c.NativeMethodInfoPtr__FromString_b__4_0_Internal_Ingredient_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryRecipe.__c>.NativeClassPtr, 100666352);
				InventoryRecipe.__c.NativeMethodInfoPtr__FromString_b__4_1_Internal_Boolean_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryRecipe.__c>.NativeClassPtr, 100666353);
			}

			// Token: 0x0600206B RID: 8299 RVA: 0x0008EE78 File Offset: 0x0008D078
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryRecipe.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryRecipe.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600206C RID: 8300 RVA: 0x0008EEB4 File Offset: 0x0008D0B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947043, XrefRangeEnd = 947044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InventoryRecipe.Ingredient _FromString_b__4_0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryRecipe.__c.NativeMethodInfoPtr__FromString_b__4_0_Internal_Ingredient_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new InventoryRecipe.Ingredient(intPtr);
				}
			}

			// Token: 0x0600206D RID: 8301 RVA: 0x0008EEFC File Offset: 0x0008D0FC
			[CallerCount(0)]
			public unsafe bool _FromString_b__4_1(InventoryRecipe.Ingredient x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryRecipe.__c.NativeMethodInfoPtr__FromString_b__4_1_Internal_Boolean_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600206E RID: 8302 RVA: 0x0000C61E File Offset: 0x0000A81E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000859 RID: 2137
			// (get) Token: 0x0600206F RID: 8303 RVA: 0x0008EF50 File Offset: 0x0008D150
			// (set) Token: 0x06002070 RID: 8304 RVA: 0x0000C627 File Offset: 0x0000A827
			public unsafe static InventoryRecipe.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InventoryRecipe.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InventoryRecipe.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InventoryRecipe.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700085A RID: 2138
			// (get) Token: 0x06002071 RID: 8305 RVA: 0x0008EF78 File Offset: 0x0008D178
			// (set) Token: 0x06002072 RID: 8306 RVA: 0x0000C639 File Offset: 0x0000A839
			public unsafe static Func<string, InventoryRecipe.Ingredient> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InventoryRecipe.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, InventoryRecipe.Ingredient>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InventoryRecipe.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700085B RID: 2139
			// (get) Token: 0x06002073 RID: 8307 RVA: 0x0008EFA0 File Offset: 0x0008D1A0
			// (set) Token: 0x06002074 RID: 8308 RVA: 0x0000C64B File Offset: 0x0000A84B
			public unsafe static Func<InventoryRecipe.Ingredient, bool> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InventoryRecipe.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InventoryRecipe.Ingredient, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InventoryRecipe.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040022C6 RID: 8902
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040022C7 RID: 8903
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x040022C8 RID: 8904
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x040022C9 RID: 8905
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040022CA RID: 8906
			private static readonly IntPtr NativeMethodInfoPtr__FromString_b__4_0_Internal_Ingredient_String_0;

			// Token: 0x040022CB RID: 8907
			private static readonly IntPtr NativeMethodInfoPtr__FromString_b__4_1_Internal_Boolean_Ingredient_0;
		}

		// Token: 0x02000280 RID: 640
		[ObfuscatedName("Steamworks.InventoryRecipe+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06002075 RID: 8309 RVA: 0x0008EFC8 File Offset: 0x0008D1C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<InventoryRecipe.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryRecipe>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryRecipe.__c__DisplayClass5_0>.NativeClassPtr);
				InventoryRecipe.__c__DisplayClass5_0.NativeFieldInfoPtr_inventoryDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryRecipe.__c__DisplayClass5_0>.NativeClassPtr, "inventoryDef");
				InventoryRecipe.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryRecipe.__c__DisplayClass5_0>.NativeClassPtr, 100666354);
				InventoryRecipe.__c__DisplayClass5_0.NativeMethodInfoPtr__ContainsIngredient_b__0_Internal_Boolean_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryRecipe.__c__DisplayClass5_0>.NativeClassPtr, 100666355);
			}

			// Token: 0x06002076 RID: 8310 RVA: 0x0008F030 File Offset: 0x0008D230
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryRecipe.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryRecipe.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002077 RID: 8311 RVA: 0x0008F06C File Offset: 0x0008D26C
			[CallerCount(0)]
			public unsafe bool _ContainsIngredient_b__0(InventoryRecipe.Ingredient x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryRecipe.__c__DisplayClass5_0.NativeMethodInfoPtr__ContainsIngredient_b__0_Internal_Boolean_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002078 RID: 8312 RVA: 0x0000C65D File Offset: 0x0000A85D
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700085C RID: 2140
			// (get) Token: 0x06002079 RID: 8313 RVA: 0x0008F0C0 File Offset: 0x0008D2C0
			// (set) Token: 0x0600207A RID: 8314 RVA: 0x0000C666 File Offset: 0x0000A866
			public unsafe InventoryDef inventoryDef
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryRecipe.__c__DisplayClass5_0.NativeFieldInfoPtr_inventoryDef);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InventoryDef>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryRecipe.__c__DisplayClass5_0.NativeFieldInfoPtr_inventoryDef), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040022CC RID: 8908
			private static readonly IntPtr NativeFieldInfoPtr_inventoryDef;

			// Token: 0x040022CD RID: 8909
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040022CE RID: 8910
			private static readonly IntPtr NativeMethodInfoPtr__ContainsIngredient_b__0_Internal_Boolean_Ingredient_0;
		}
	}
}
