using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000BB RID: 187
	public class InventoryDef : Object
	{
		// Token: 0x06000C02 RID: 3074 RVA: 0x00050F70 File Offset: 0x0004F170
		// Note: this type is marked as 'beforefieldinit'.
		static InventoryDef()
		{
			Il2CppClassPointerStore<InventoryDef>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "InventoryDef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr);
			InventoryDef.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, "_id");
			InventoryDef.NativeFieldInfoPtr__properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, "_properties");
			InventoryDef.NativeFieldInfoPtr__recContaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, "_recContaining");
			InventoryDef.NativeMethodInfoPtr__ctor_Public_Void_InventoryDefId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666272);
			InventoryDef.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666273);
			InventoryDef.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666274);
			InventoryDef.NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666275);
			InventoryDef.NativeMethodInfoPtr_get_IconUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666276);
			InventoryDef.NativeMethodInfoPtr_get_IconUrlLarge_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666277);
			InventoryDef.NativeMethodInfoPtr_get_PriceCategory_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666278);
			InventoryDef.NativeMethodInfoPtr_get_Type_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666279);
			InventoryDef.NativeMethodInfoPtr_get_IsGenerator_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666280);
			InventoryDef.NativeMethodInfoPtr_get_ExchangeSchema_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666281);
			InventoryDef.NativeMethodInfoPtr_GetRecipes_Public_Il2CppReferenceArray_1_InventoryRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666282);
			InventoryDef.NativeMethodInfoPtr_get_Marketable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666283);
			InventoryDef.NativeMethodInfoPtr_get_Tradable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666284);
			InventoryDef.NativeMethodInfoPtr_get_Created_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666285);
			InventoryDef.NativeMethodInfoPtr_get_Modified_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666286);
			InventoryDef.NativeMethodInfoPtr_GetProperty_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666287);
			InventoryDef.NativeMethodInfoPtr_GetBoolProperty_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666288);
			InventoryDef.NativeMethodInfoPtr_GetProperty_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666289);
			InventoryDef.NativeMethodInfoPtr_get_Properties_Public_get_IEnumerable_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666290);
			InventoryDef.NativeMethodInfoPtr_get_LocalPrice_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666291);
			InventoryDef.NativeMethodInfoPtr_get_LocalPriceFormatted_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666292);
			InventoryDef.NativeMethodInfoPtr_get_LocalBasePrice_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666293);
			InventoryDef.NativeMethodInfoPtr_get_LocalBasePriceFormatted_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666294);
			InventoryDef.NativeMethodInfoPtr_GetRecipesContainingThis_Public_Il2CppReferenceArray_1_InventoryRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666295);
			InventoryDef.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InventoryDef_InventoryDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666296);
			InventoryDef.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InventoryDef_InventoryDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666297);
			InventoryDef.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666298);
			InventoryDef.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666299);
			InventoryDef.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InventoryDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666300);
			InventoryDef.NativeMethodInfoPtr__GetRecipes_b__21_0_Private_InventoryRecipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666301);
			InventoryDef.NativeMethodInfoPtr__GetRecipesContainingThis_b__44_3_Private_Boolean_InventoryRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, 100666302);
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00051248 File Offset: 0x0004F448
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 946603, RefRangeEnd = 946605, XrefRangeStart = 946602, XrefRangeEnd = 946603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InventoryDef(InventoryDefId defId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref defId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr__ctor_Public_Void_InventoryDefId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x00051290 File Offset: 0x0004F490
		public unsafe int Id
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x000512CC File Offset: 0x0004F4CC
		public unsafe string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946605, XrefRangeEnd = 946608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x00051304 File Offset: 0x0004F504
		public unsafe string Description
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946608, XrefRangeEnd = 946611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_get_Description_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x0005133C File Offset: 0x0004F53C
		public unsafe string IconUrl
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946611, XrefRangeEnd = 946614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_get_IconUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x00051374 File Offset: 0x0004F574
		public unsafe string IconUrlLarge
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946614, XrefRangeEnd = 946617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_get_IconUrlLarge_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x000513AC File Offset: 0x0004F5AC
		public unsafe string PriceCategory
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946617, XrefRangeEnd = 946620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_get_PriceCategory_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x000513E4 File Offset: 0x0004F5E4
		public unsafe string Type
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946620, XrefRangeEnd = 946623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_get_Type_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x0005141C File Offset: 0x0004F61C
		public unsafe bool IsGenerator
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946623, XrefRangeEnd = 946629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_get_IsGenerator_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x00051458 File Offset: 0x0004F658
		public unsafe string ExchangeSchema
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946629, XrefRangeEnd = 946632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_get_ExchangeSchema_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00051490 File Offset: 0x0004F690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946632, XrefRangeEnd = 946655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<InventoryRecipe> GetRecipes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_GetRecipes_Public_Il2CppReferenceArray_1_InventoryRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InventoryRecipe>>(intPtr3) : null;
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x000514D0 File Offset: 0x0004F6D0
		public unsafe bool Marketable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946655, XrefRangeEnd = 946661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_get_Marketable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x0005150C File Offset: 0x0004F70C
		public unsafe bool Tradable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946661, XrefRangeEnd = 946667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_get_Tradable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x00051548 File Offset: 0x0004F748
		public unsafe DateTime Created
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946667, XrefRangeEnd = 946672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_get_Created_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x00051584 File Offset: 0x0004F784
		public unsafe DateTime Modified
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946672, XrefRangeEnd = 946677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_get_Modified_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x000515C0 File Offset: 0x0004F7C0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 946683, RefRangeEnd = 946701, XrefRangeStart = 946677, XrefRangeEnd = 946683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetProperty(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_GetProperty_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00051608 File Offset: 0x0004F808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946701, XrefRangeEnd = 946705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetBoolProperty(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_GetBoolProperty_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00051658 File Offset: 0x0004F858
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 946719, RefRangeEnd = 946721, XrefRangeStart = 946705, XrefRangeEnd = 946719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetProperty<T>(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.MethodInfoStoreGeneric_GetProperty_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x000516A4 File Offset: 0x0004F8A4
		public unsafe IEnumerable<KeyValuePair<string, string>> Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946721, XrefRangeEnd = 946727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_get_Properties_Public_get_IEnumerable_1_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, string>>>(intPtr3) : null;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x000516E4 File Offset: 0x0004F8E4
		public unsafe int LocalPrice
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946727, XrefRangeEnd = 946730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_get_LocalPrice_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x00051720 File Offset: 0x0004F920
		public unsafe string LocalPriceFormatted
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946730, XrefRangeEnd = 946740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_get_LocalPriceFormatted_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x00051758 File Offset: 0x0004F958
		public unsafe int LocalBasePrice
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946740, XrefRangeEnd = 946743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_get_LocalBasePrice_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x00051794 File Offset: 0x0004F994
		public unsafe string LocalBasePriceFormatted
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946743, XrefRangeEnd = 946753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_get_LocalBasePriceFormatted_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x000517CC File Offset: 0x0004F9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946753, XrefRangeEnd = 946820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<InventoryRecipe> GetRecipesContainingThis()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_GetRecipesContainingThis_Public_Il2CppReferenceArray_1_InventoryRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InventoryRecipe>>(intPtr3) : null;
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0005180C File Offset: 0x0004FA0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 946821, RefRangeEnd = 946823, XrefRangeStart = 946820, XrefRangeEnd = 946821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(InventoryDef a, InventoryDef b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InventoryDef_InventoryDef_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00051860 File Offset: 0x0004FA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946823, XrefRangeEnd = 946824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(InventoryDef a, InventoryDef b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InventoryDef_InventoryDef_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x000518B4 File Offset: 0x0004FAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946824, XrefRangeEnd = 946827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InventoryDef.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0005190C File Offset: 0x0004FB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946827, XrefRangeEnd = 946828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InventoryDef.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00051954 File Offset: 0x0004FB54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 946829, RefRangeEnd = 946831, XrefRangeStart = 946828, XrefRangeEnd = 946829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(InventoryDef p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InventoryDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x000519A4 File Offset: 0x0004FBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946831, XrefRangeEnd = 946832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InventoryRecipe _GetRecipes_b__21_0(string x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr__GetRecipes_b__21_0_Private_InventoryRecipe_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new InventoryRecipe(intPtr);
			}
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x000519EC File Offset: 0x0004FBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946832, XrefRangeEnd = 946833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetRecipesContainingThis_b__44_3(InventoryRecipe x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.NativeMethodInfoPtr__GetRecipesContainingThis_b__44_3_Private_Boolean_InventoryRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00002F05 File Offset: 0x00001105
		public InventoryDef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x00051A40 File Offset: 0x0004FC40
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x00002F0E File Offset: 0x0000110E
		public unsafe InventoryDefId _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryDef.NativeFieldInfoPtr__id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryDef.NativeFieldInfoPtr__id)) = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x00051A68 File Offset: 0x0004FC68
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x00002F29 File Offset: 0x00001129
		public unsafe Dictionary<string, string> _properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryDef.NativeFieldInfoPtr__properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryDef.NativeFieldInfoPtr__properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x00051A98 File Offset: 0x0004FC98
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x00002F48 File Offset: 0x00001148
		public unsafe Il2CppReferenceArray<InventoryRecipe> _recContaining
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryDef.NativeFieldInfoPtr__recContaining);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InventoryRecipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryDef.NativeFieldInfoPtr__recContaining), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012B1 RID: 4785
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x040012B2 RID: 4786
		private static readonly IntPtr NativeFieldInfoPtr__properties;

		// Token: 0x040012B3 RID: 4787
		private static readonly IntPtr NativeFieldInfoPtr__recContaining;

		// Token: 0x040012B4 RID: 4788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InventoryDefId_0;

		// Token: 0x040012B5 RID: 4789
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x040012B6 RID: 4790
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x040012B7 RID: 4791
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;

		// Token: 0x040012B8 RID: 4792
		private static readonly IntPtr NativeMethodInfoPtr_get_IconUrl_Public_get_String_0;

		// Token: 0x040012B9 RID: 4793
		private static readonly IntPtr NativeMethodInfoPtr_get_IconUrlLarge_Public_get_String_0;

		// Token: 0x040012BA RID: 4794
		private static readonly IntPtr NativeMethodInfoPtr_get_PriceCategory_Public_get_String_0;

		// Token: 0x040012BB RID: 4795
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_String_0;

		// Token: 0x040012BC RID: 4796
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenerator_Public_get_Boolean_0;

		// Token: 0x040012BD RID: 4797
		private static readonly IntPtr NativeMethodInfoPtr_get_ExchangeSchema_Public_get_String_0;

		// Token: 0x040012BE RID: 4798
		private static readonly IntPtr NativeMethodInfoPtr_GetRecipes_Public_Il2CppReferenceArray_1_InventoryRecipe_0;

		// Token: 0x040012BF RID: 4799
		private static readonly IntPtr NativeMethodInfoPtr_get_Marketable_Public_get_Boolean_0;

		// Token: 0x040012C0 RID: 4800
		private static readonly IntPtr NativeMethodInfoPtr_get_Tradable_Public_get_Boolean_0;

		// Token: 0x040012C1 RID: 4801
		private static readonly IntPtr NativeMethodInfoPtr_get_Created_Public_get_DateTime_0;

		// Token: 0x040012C2 RID: 4802
		private static readonly IntPtr NativeMethodInfoPtr_get_Modified_Public_get_DateTime_0;

		// Token: 0x040012C3 RID: 4803
		private static readonly IntPtr NativeMethodInfoPtr_GetProperty_Public_String_String_0;

		// Token: 0x040012C4 RID: 4804
		private static readonly IntPtr NativeMethodInfoPtr_GetBoolProperty_Public_Boolean_String_0;

		// Token: 0x040012C5 RID: 4805
		private static readonly IntPtr NativeMethodInfoPtr_GetProperty_Public_T_String_0;

		// Token: 0x040012C6 RID: 4806
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_get_IEnumerable_1_KeyValuePair_2_String_String_0;

		// Token: 0x040012C7 RID: 4807
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPrice_Public_get_Int32_0;

		// Token: 0x040012C8 RID: 4808
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPriceFormatted_Public_get_String_0;

		// Token: 0x040012C9 RID: 4809
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalBasePrice_Public_get_Int32_0;

		// Token: 0x040012CA RID: 4810
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalBasePriceFormatted_Public_get_String_0;

		// Token: 0x040012CB RID: 4811
		private static readonly IntPtr NativeMethodInfoPtr_GetRecipesContainingThis_Public_Il2CppReferenceArray_1_InventoryRecipe_0;

		// Token: 0x040012CC RID: 4812
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InventoryDef_InventoryDef_0;

		// Token: 0x040012CD RID: 4813
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InventoryDef_InventoryDef_0;

		// Token: 0x040012CE RID: 4814
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040012CF RID: 4815
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040012D0 RID: 4816
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InventoryDef_0;

		// Token: 0x040012D1 RID: 4817
		private static readonly IntPtr NativeMethodInfoPtr__GetRecipes_b__21_0_Private_InventoryRecipe_String_0;

		// Token: 0x040012D2 RID: 4818
		private static readonly IntPtr NativeMethodInfoPtr__GetRecipesContainingThis_b__44_3_Private_Boolean_InventoryRecipe_0;

		// Token: 0x02000277 RID: 631
		[ObfuscatedName("Steamworks.InventoryDef+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002005 RID: 8197 RVA: 0x0008DE48 File Offset: 0x0008C048
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<InventoryDef.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryDef.__c>.NativeClassPtr);
				InventoryDef.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDef.__c>.NativeClassPtr, "<>9");
				InventoryDef.__c.NativeFieldInfoPtr___9__44_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDef.__c>.NativeClassPtr, "<>9__44_0");
				InventoryDef.__c.NativeFieldInfoPtr___9__44_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDef.__c>.NativeClassPtr, "<>9__44_1");
				InventoryDef.__c.NativeFieldInfoPtr___9__44_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDef.__c>.NativeClassPtr, "<>9__44_2");
				InventoryDef.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef.__c>.NativeClassPtr, 100666304);
				InventoryDef.__c.NativeMethodInfoPtr__GetRecipesContainingThis_b__44_0_Internal_Il2CppReferenceArray_1_InventoryRecipe_InventoryDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef.__c>.NativeClassPtr, 100666305);
				InventoryDef.__c.NativeMethodInfoPtr__GetRecipesContainingThis_b__44_1_Internal_Boolean_Il2CppReferenceArray_1_InventoryRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef.__c>.NativeClassPtr, 100666306);
				InventoryDef.__c.NativeMethodInfoPtr__GetRecipesContainingThis_b__44_2_Internal_IEnumerable_1_InventoryRecipe_Il2CppReferenceArray_1_InventoryRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef.__c>.NativeClassPtr, 100666307);
			}

			// Token: 0x06002006 RID: 8198 RVA: 0x0008DF14 File Offset: 0x0008C114
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryDef.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002007 RID: 8199 RVA: 0x0008DF50 File Offset: 0x0008C150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946557, XrefRangeEnd = 946580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<InventoryRecipe> _GetRecipesContainingThis_b__44_0(InventoryDef x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.__c.NativeMethodInfoPtr__GetRecipesContainingThis_b__44_0_Internal_Il2CppReferenceArray_1_InventoryRecipe_InventoryDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InventoryRecipe>>(intPtr3) : null;
				}
			}

			// Token: 0x06002008 RID: 8200 RVA: 0x0008DFA0 File Offset: 0x0008C1A0
			[CallerCount(0)]
			public unsafe bool _GetRecipesContainingThis_b__44_1(Il2CppReferenceArray<InventoryRecipe> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.__c.NativeMethodInfoPtr__GetRecipesContainingThis_b__44_1_Internal_Boolean_Il2CppReferenceArray_1_InventoryRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002009 RID: 8201 RVA: 0x0008DFF0 File Offset: 0x0008C1F0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<InventoryRecipe> _GetRecipesContainingThis_b__44_2(Il2CppReferenceArray<InventoryRecipe> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef.__c.NativeMethodInfoPtr__GetRecipesContainingThis_b__44_2_Internal_IEnumerable_1_InventoryRecipe_Il2CppReferenceArray_1_InventoryRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<InventoryRecipe>>(intPtr3) : null;
				}
			}

			// Token: 0x0600200A RID: 8202 RVA: 0x0000C174 File Offset: 0x0000A374
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000838 RID: 2104
			// (get) Token: 0x0600200B RID: 8203 RVA: 0x0008E040 File Offset: 0x0008C240
			// (set) Token: 0x0600200C RID: 8204 RVA: 0x0000C17D File Offset: 0x0000A37D
			public unsafe static InventoryDef.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InventoryDef.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InventoryDef.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InventoryDef.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000839 RID: 2105
			// (get) Token: 0x0600200D RID: 8205 RVA: 0x0008E068 File Offset: 0x0008C268
			// (set) Token: 0x0600200E RID: 8206 RVA: 0x0000C18F File Offset: 0x0000A38F
			public unsafe static Func<InventoryDef, Il2CppReferenceArray<InventoryRecipe>> __9__44_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InventoryDef.__c.NativeFieldInfoPtr___9__44_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InventoryDef, Il2CppReferenceArray<InventoryRecipe>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InventoryDef.__c.NativeFieldInfoPtr___9__44_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700083A RID: 2106
			// (get) Token: 0x0600200F RID: 8207 RVA: 0x0008E090 File Offset: 0x0008C290
			// (set) Token: 0x06002010 RID: 8208 RVA: 0x0000C1A1 File Offset: 0x0000A3A1
			public unsafe static Func<Il2CppReferenceArray<InventoryRecipe>, bool> __9__44_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InventoryDef.__c.NativeFieldInfoPtr___9__44_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppReferenceArray<InventoryRecipe>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InventoryDef.__c.NativeFieldInfoPtr___9__44_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700083B RID: 2107
			// (get) Token: 0x06002011 RID: 8209 RVA: 0x0008E0B8 File Offset: 0x0008C2B8
			// (set) Token: 0x06002012 RID: 8210 RVA: 0x0000C1B3 File Offset: 0x0000A3B3
			public unsafe static Func<Il2CppReferenceArray<InventoryRecipe>, IEnumerable<InventoryRecipe>> __9__44_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InventoryDef.__c.NativeFieldInfoPtr___9__44_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppReferenceArray<InventoryRecipe>, IEnumerable<InventoryRecipe>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InventoryDef.__c.NativeFieldInfoPtr___9__44_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002293 RID: 8851
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002294 RID: 8852
			private static readonly IntPtr NativeFieldInfoPtr___9__44_0;

			// Token: 0x04002295 RID: 8853
			private static readonly IntPtr NativeFieldInfoPtr___9__44_1;

			// Token: 0x04002296 RID: 8854
			private static readonly IntPtr NativeFieldInfoPtr___9__44_2;

			// Token: 0x04002297 RID: 8855
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002298 RID: 8856
			private static readonly IntPtr NativeMethodInfoPtr__GetRecipesContainingThis_b__44_0_Internal_Il2CppReferenceArray_1_InventoryRecipe_InventoryDef_0;

			// Token: 0x04002299 RID: 8857
			private static readonly IntPtr NativeMethodInfoPtr__GetRecipesContainingThis_b__44_1_Internal_Boolean_Il2CppReferenceArray_1_InventoryRecipe_0;

			// Token: 0x0400229A RID: 8858
			private static readonly IntPtr NativeMethodInfoPtr__GetRecipesContainingThis_b__44_2_Internal_IEnumerable_1_InventoryRecipe_Il2CppReferenceArray_1_InventoryRecipe_0;
		}

		// Token: 0x02000278 RID: 632
		[ObfuscatedName("Steamworks.InventoryDef+<get_Properties>d__34")]
		public sealed class _get_Properties_d__34 : Object
		{
			// Token: 0x06002013 RID: 8211 RVA: 0x0008E0E0 File Offset: 0x0008C2E0
			// Note: this type is marked as 'beforefieldinit'.
			static _get_Properties_d__34()
			{
				Il2CppClassPointerStore<InventoryDef._get_Properties_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryDef>.NativeClassPtr, "<get_Properties>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryDef._get_Properties_d__34>.NativeClassPtr);
				InventoryDef._get_Properties_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDef._get_Properties_d__34>.NativeClassPtr, "<>1__state");
				InventoryDef._get_Properties_d__34.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDef._get_Properties_d__34>.NativeClassPtr, "<>2__current");
				InventoryDef._get_Properties_d__34.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDef._get_Properties_d__34>.NativeClassPtr, "<>l__initialThreadId");
				InventoryDef._get_Properties_d__34.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDef._get_Properties_d__34>.NativeClassPtr, "<>4__this");
				InventoryDef._get_Properties_d__34.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDef._get_Properties_d__34>.NativeClassPtr, "<>7__wrap1");
				InventoryDef._get_Properties_d__34.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDef._get_Properties_d__34>.NativeClassPtr, "<>7__wrap2");
				InventoryDef._get_Properties_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef._get_Properties_d__34>.NativeClassPtr, 100666308);
				InventoryDef._get_Properties_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef._get_Properties_d__34>.NativeClassPtr, 100666309);
				InventoryDef._get_Properties_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef._get_Properties_d__34>.NativeClassPtr, 100666310);
				InventoryDef._get_Properties_d__34.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef._get_Properties_d__34>.NativeClassPtr, 100666311);
				InventoryDef._get_Properties_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef._get_Properties_d__34>.NativeClassPtr, 100666312);
				InventoryDef._get_Properties_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef._get_Properties_d__34>.NativeClassPtr, 100666313);
				InventoryDef._get_Properties_d__34.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef._get_Properties_d__34>.NativeClassPtr, 100666314);
				InventoryDef._get_Properties_d__34.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDef._get_Properties_d__34>.NativeClassPtr, 100666315);
			}

			// Token: 0x06002014 RID: 8212 RVA: 0x0008E224 File Offset: 0x0008C424
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_Properties_d__34(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryDef._get_Properties_d__34>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef._get_Properties_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002015 RID: 8213 RVA: 0x0008E26C File Offset: 0x0008C46C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef._get_Properties_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002016 RID: 8214 RVA: 0x0008E2A0 File Offset: 0x0008C4A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946580, XrefRangeEnd = 946592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef._get_Properties_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000842 RID: 2114
			// (get) Token: 0x06002017 RID: 8215 RVA: 0x0008E2DC File Offset: 0x0008C4DC
			public unsafe KeyValuePair<string, string> prop_KeyValuePair_2_String_String_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef._get_Properties_d__34.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<string, string>(intPtr);
				}
			}

			// Token: 0x06002018 RID: 8216 RVA: 0x0008E314 File Offset: 0x0008C514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946592, XrefRangeEnd = 946597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef._get_Properties_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000843 RID: 2115
			// (get) Token: 0x06002019 RID: 8217 RVA: 0x0008E348 File Offset: 0x0008C548
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946597, XrefRangeEnd = 946600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef._get_Properties_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600201A RID: 8218 RVA: 0x0008E388 File Offset: 0x0008C588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946600, XrefRangeEnd = 946602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<KeyValuePair<string, string>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef._get_Properties_d__34.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<string, string>>>(intPtr3) : null;
			}

			// Token: 0x0600201B RID: 8219 RVA: 0x0008E3C8 File Offset: 0x0008C5C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDef._get_Properties_d__34.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600201C RID: 8220 RVA: 0x0000C1C5 File Offset: 0x0000A3C5
			public _get_Properties_d__34(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700083C RID: 2108
			// (get) Token: 0x0600201D RID: 8221 RVA: 0x0008E408 File Offset: 0x0008C608
			// (set) Token: 0x0600201E RID: 8222 RVA: 0x0000C1CE File Offset: 0x0000A3CE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryDef._get_Properties_d__34.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryDef._get_Properties_d__34.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700083D RID: 2109
			// (get) Token: 0x0600201F RID: 8223 RVA: 0x0008E430 File Offset: 0x0008C630
			// (set) Token: 0x06002020 RID: 8224 RVA: 0x0000C1E9 File Offset: 0x0000A3E9
			public KeyValuePair<string, string> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryDef._get_Properties_d__34.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<string, string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryDef._get_Properties_d__34.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700083E RID: 2110
			// (get) Token: 0x06002021 RID: 8225 RVA: 0x0008E460 File Offset: 0x0008C660
			// (set) Token: 0x06002022 RID: 8226 RVA: 0x0000C217 File Offset: 0x0000A417
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryDef._get_Properties_d__34.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryDef._get_Properties_d__34.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700083F RID: 2111
			// (get) Token: 0x06002023 RID: 8227 RVA: 0x0008E488 File Offset: 0x0008C688
			// (set) Token: 0x06002024 RID: 8228 RVA: 0x0000C232 File Offset: 0x0000A432
			public unsafe InventoryDef __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryDef._get_Properties_d__34.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InventoryDef>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryDef._get_Properties_d__34.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000840 RID: 2112
			// (get) Token: 0x06002025 RID: 8229 RVA: 0x0008E4B8 File Offset: 0x0008C6B8
			// (set) Token: 0x06002026 RID: 8230 RVA: 0x0000C251 File Offset: 0x0000A451
			public unsafe Il2CppStringArray __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryDef._get_Properties_d__34.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryDef._get_Properties_d__34.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000841 RID: 2113
			// (get) Token: 0x06002027 RID: 8231 RVA: 0x0008E4E8 File Offset: 0x0008C6E8
			// (set) Token: 0x06002028 RID: 8232 RVA: 0x0000C270 File Offset: 0x0000A470
			public unsafe int __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryDef._get_Properties_d__34.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryDef._get_Properties_d__34.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x0400229B RID: 8859
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400229C RID: 8860
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400229D RID: 8861
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400229E RID: 8862
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400229F RID: 8863
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040022A0 RID: 8864
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040022A1 RID: 8865
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040022A2 RID: 8866
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040022A3 RID: 8867
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040022A4 RID: 8868
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_String_0;

			// Token: 0x040022A5 RID: 8869
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040022A6 RID: 8870
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040022A7 RID: 8871
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0;

			// Token: 0x040022A8 RID: 8872
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000279 RID: 633
		private sealed class MethodInfoStoreGeneric_GetProperty_Public_T_String_0<T>
		{
			// Token: 0x040022A9 RID: 8873
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(InventoryDef.NativeMethodInfoPtr_GetProperty_Public_T_String_0, Il2CppClassPointerStore<InventoryDef>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
