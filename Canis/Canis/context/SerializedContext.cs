using System;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.context
{
	// Token: 0x02000119 RID: 281
	[Serializable]
	public class SerializedContext : Object
	{
		// Token: 0x06000CC8 RID: 3272 RVA: 0x000507D8 File Offset: 0x0004E9D8
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedContext()
		{
			Il2CppClassPointerStore<SerializedContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context", "SerializedContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedContext>.NativeClassPtr);
			SerializedContext.NativeFieldInfoPtr_SourceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedContext>.NativeClassPtr, "SourceID");
			SerializedContext.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedContext>.NativeClassPtr, "Target");
			SerializedContext.NativeFieldInfoPtr_Parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedContext>.NativeClassPtr, "Parameters");
			SerializedContext.NativeMethodInfoPtr_GenContext_Public_Context_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedContext>.NativeClassPtr, 100666224);
			SerializedContext.NativeMethodInfoPtr_Reified_Public_Static_Object_Match_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedContext>.NativeClassPtr, 100666225);
			SerializedContext.NativeMethodInfoPtr_GetEnumTypeByName_Public_Static_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedContext>.NativeClassPtr, 100666226);
			SerializedContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedContext>.NativeClassPtr, 100666227);
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00050894 File Offset: 0x0004EA94
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 575720, RefRangeEnd = 575731, XrefRangeStart = 575677, XrefRangeEnd = 575720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Context GenContext(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedContext.NativeMethodInfoPtr_GenContext_Public_Context_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x000508E4 File Offset: 0x0004EAE4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 575789, RefRangeEnd = 575794, XrefRangeStart = 575731, XrefRangeEnd = 575789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Reified(Match match, string unknownStr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(unknownStr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedContext.NativeMethodInfoPtr_Reified_Public_Static_Object_Match_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x0005093C File Offset: 0x0004EB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575794, XrefRangeEnd = 575801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetEnumTypeByName(string enumName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(enumName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedContext.NativeMethodInfoPtr_GetEnumTypeByName_Public_Static_Type_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x00050980 File Offset: 0x0004EB80
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x000067B6 File Offset: 0x000049B6
		public SerializedContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x000509BC File Offset: 0x0004EBBC
		// (set) Token: 0x06000CCF RID: 3279 RVA: 0x000067BF File Offset: 0x000049BF
		public unsafe EntityID SourceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedContext.NativeFieldInfoPtr_SourceID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedContext.NativeFieldInfoPtr_SourceID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x000509EC File Offset: 0x0004EBEC
		// (set) Token: 0x06000CD1 RID: 3281 RVA: 0x000067DE File Offset: 0x000049DE
		public unsafe string Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedContext.NativeFieldInfoPtr_Target);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedContext.NativeFieldInfoPtr_Target), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x00050A14 File Offset: 0x0004EC14
		// (set) Token: 0x06000CD3 RID: 3283 RVA: 0x000067FD File Offset: 0x000049FD
		public unsafe Dictionary<string, string> Parameters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedContext.NativeFieldInfoPtr_Parameters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedContext.NativeFieldInfoPtr_Parameters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeFieldInfoPtr_SourceID;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeFieldInfoPtr_Parameters;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeMethodInfoPtr_GenContext_Public_Context_Match_0;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeMethodInfoPtr_Reified_Public_Static_Object_Match_String_0;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumTypeByName_Public_Static_Type_String_0;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000381 RID: 897
		[ObfuscatedName("Canis.context.SerializedContext+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06002582 RID: 9602 RVA: 0x000A64D0 File Offset: 0x000A46D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<SerializedContext.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializedContext>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedContext.__c__DisplayClass4_0>.NativeClassPtr);
				SerializedContext.__c__DisplayClass4_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedContext.__c__DisplayClass4_0>.NativeClassPtr, "match");
				SerializedContext.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedContext.__c__DisplayClass4_0>.NativeClassPtr, 100666228);
				SerializedContext.__c__DisplayClass4_0.NativeMethodInfoPtr__Reified_b__0_Internal_Entity_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedContext.__c__DisplayClass4_0>.NativeClassPtr, 100666229);
				SerializedContext.__c__DisplayClass4_0.NativeMethodInfoPtr__Reified_b__1_Internal_Entity_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedContext.__c__DisplayClass4_0>.NativeClassPtr, 100666230);
			}

			// Token: 0x06002583 RID: 9603 RVA: 0x000A654C File Offset: 0x000A474C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedContext.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedContext.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002584 RID: 9604 RVA: 0x000A6588 File Offset: 0x000A4788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575578, XrefRangeEnd = 575582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _Reified_b__0(EntityID eid)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(eid);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedContext.__c__DisplayClass4_0.NativeMethodInfoPtr__Reified_b__0_Internal_Entity_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06002585 RID: 9605 RVA: 0x000A65D8 File Offset: 0x000A47D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575582, XrefRangeEnd = 575677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _Reified_b__1(EntityID eid)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(eid);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedContext.__c__DisplayClass4_0.NativeMethodInfoPtr__Reified_b__1_Internal_Entity_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06002586 RID: 9606 RVA: 0x00011E9D File Offset: 0x0001009D
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000938 RID: 2360
			// (get) Token: 0x06002587 RID: 9607 RVA: 0x000A6628 File Offset: 0x000A4828
			// (set) Token: 0x06002588 RID: 9608 RVA: 0x00011EA6 File Offset: 0x000100A6
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedContext.__c__DisplayClass4_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedContext.__c__DisplayClass4_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001775 RID: 6005
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001776 RID: 6006
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001777 RID: 6007
			private static readonly IntPtr NativeMethodInfoPtr__Reified_b__0_Internal_Entity_EntityID_0;

			// Token: 0x04001778 RID: 6008
			private static readonly IntPtr NativeMethodInfoPtr__Reified_b__1_Internal_Entity_EntityID_0;
		}
	}
}
