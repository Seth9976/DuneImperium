using System;
using Canis.actions;
using Canis.actions.responseparsers;
using Canis.context.propertiesphrases;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.context.targetpickers
{
	// Token: 0x02000126 RID: 294
	public class TakeFrom : TargetPicker<Entity>
	{
		// Token: 0x06000DA8 RID: 3496 RVA: 0x00053A1C File Offset: 0x00051C1C
		// Note: this type is marked as 'beforefieldinit'.
		static TakeFrom()
		{
			Il2CppClassPointerStore<TakeFrom>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.targetpickers", "TakeFrom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TakeFrom>.NativeClassPtr);
			TakeFrom.NativeFieldInfoPtr_number = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeFrom>.NativeClassPtr, "number");
			TakeFrom.NativeFieldInfoPtr_pile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeFrom>.NativeClassPtr, "pile");
			TakeFrom.NativeFieldInfoPtr_propertiesPhrases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeFrom>.NativeClassPtr, "propertiesPhrases");
			TakeFrom.NativeFieldInfoPtr_choice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeFrom>.NativeClassPtr, "choice");
			TakeFrom.NativeMethodInfoPtr__ctor_Public_Void_Int32_Entity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeFrom>.NativeClassPtr, 100666337);
			TakeFrom.NativeMethodInfoPtr_With_Public_TakeFrom_Func_2_Context_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeFrom>.NativeClassPtr, 100666338);
			TakeFrom.NativeMethodInfoPtr_With_Public_TakeFrom_PropertiesPhrase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeFrom>.NativeClassPtr, 100666339);
			TakeFrom.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeFrom>.NativeClassPtr, 100666340);
			TakeFrom.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeFrom>.NativeClassPtr, 100666341);
			TakeFrom.NativeMethodInfoPtr__PickTargets_b__9_0_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeFrom>.NativeClassPtr, 100666342);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00053B14 File Offset: 0x00051D14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 576872, RefRangeEnd = 576874, XrefRangeStart = 576854, XrefRangeEnd = 576872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TakeFrom(int number, Entity pile, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TakeFrom>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeFrom.NativeMethodInfoPtr__ctor_Public_Void_Int32_Entity_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00053B80 File Offset: 0x00051D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576874, XrefRangeEnd = 576877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TakeFrom With(Func<Context, bool> propertiesPhrase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertiesPhrase);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeFrom.NativeMethodInfoPtr_With_Public_TakeFrom_Func_2_Context_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TakeFrom>(intPtr3) : null;
			}
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00053BD0 File Offset: 0x00051DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576877, XrefRangeEnd = 576886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TakeFrom With(PropertiesPhrase propertiesPhrase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertiesPhrase);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeFrom.NativeMethodInfoPtr_With_Public_TakeFrom_PropertiesPhrase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TakeFrom>(intPtr3) : null;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000DAC RID: 3500 RVA: 0x00053C20 File Offset: 0x00051E20
		public unsafe override ResponseParser<Entity> responseParser
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576886, XrefRangeEnd = 576892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TakeFrom.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResponseParser<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00053C6C File Offset: 0x00051E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576892, XrefRangeEnd = 576913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SelectionRequest PickTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TakeFrom.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionRequest>(intPtr3) : null;
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00053CB8 File Offset: 0x00051EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576913, XrefRangeEnd = 576929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PickTargets_b__9_0(Entity _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeFrom.NativeMethodInfoPtr__PickTargets_b__9_0_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00006F65 File Offset: 0x00005165
		public TakeFrom(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000DB0 RID: 3504 RVA: 0x00053D08 File Offset: 0x00051F08
		// (set) Token: 0x06000DB1 RID: 3505 RVA: 0x00006F6E File Offset: 0x0000516E
		public unsafe int number
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeFrom.NativeFieldInfoPtr_number);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeFrom.NativeFieldInfoPtr_number)) = value;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x00053D30 File Offset: 0x00051F30
		// (set) Token: 0x06000DB3 RID: 3507 RVA: 0x00006F89 File Offset: 0x00005189
		public unsafe Entity pile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeFrom.NativeFieldInfoPtr_pile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeFrom.NativeFieldInfoPtr_pile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x00053D60 File Offset: 0x00051F60
		// (set) Token: 0x06000DB5 RID: 3509 RVA: 0x00006FA8 File Offset: 0x000051A8
		public unsafe List<Func<Context, bool>> propertiesPhrases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeFrom.NativeFieldInfoPtr_propertiesPhrases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Func<Context, bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeFrom.NativeFieldInfoPtr_propertiesPhrases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x00053D90 File Offset: 0x00051F90
		// (set) Token: 0x06000DB7 RID: 3511 RVA: 0x00006FC7 File Offset: 0x000051C7
		public unsafe List<Entity> choice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeFrom.NativeFieldInfoPtr_choice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeFrom.NativeFieldInfoPtr_choice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeFieldInfoPtr_number;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeFieldInfoPtr_pile;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeFieldInfoPtr_propertiesPhrases;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeFieldInfoPtr_choice;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Entity_Match_0;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeMethodInfoPtr_With_Public_TakeFrom_Func_2_Context_Boolean_0;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeMethodInfoPtr_With_Public_TakeFrom_PropertiesPhrase_0;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Entity_0;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeMethodInfoPtr__PickTargets_b__9_0_Private_Boolean_Entity_0;

		// Token: 0x0200038C RID: 908
		[ObfuscatedName("Canis.context.targetpickers.TakeFrom+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x060025E5 RID: 9701 RVA: 0x000A7774 File Offset: 0x000A5974
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<TakeFrom.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TakeFrom>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TakeFrom.__c__DisplayClass9_0>.NativeClassPtr);
				TakeFrom.__c__DisplayClass9_0.NativeFieldInfoPtr__ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeFrom.__c__DisplayClass9_0>.NativeClassPtr, "_");
				TakeFrom.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeFrom.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				TakeFrom.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeFrom.__c__DisplayClass9_0>.NativeClassPtr, 100666343);
				TakeFrom.__c__DisplayClass9_0.NativeMethodInfoPtr__PickTargets_b__1_Internal_Boolean_Func_2_Context_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeFrom.__c__DisplayClass9_0>.NativeClassPtr, 100666344);
			}

			// Token: 0x060025E6 RID: 9702 RVA: 0x000A77F0 File Offset: 0x000A59F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TakeFrom.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeFrom.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025E7 RID: 9703 RVA: 0x000A782C File Offset: 0x000A5A2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PickTargets_b__1(Func<Context, bool> allow)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(allow);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TakeFrom.__c__DisplayClass9_0.NativeMethodInfoPtr__PickTargets_b__1_Internal_Boolean_Func_2_Context_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060025E8 RID: 9704 RVA: 0x00012130 File Offset: 0x00010330
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000951 RID: 2385
			// (get) Token: 0x060025E9 RID: 9705 RVA: 0x000A787C File Offset: 0x000A5A7C
			// (set) Token: 0x060025EA RID: 9706 RVA: 0x00012139 File Offset: 0x00010339
			public unsafe Entity _
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeFrom.__c__DisplayClass9_0.NativeFieldInfoPtr__);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeFrom.__c__DisplayClass9_0.NativeFieldInfoPtr__), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000952 RID: 2386
			// (get) Token: 0x060025EB RID: 9707 RVA: 0x000A78AC File Offset: 0x000A5AAC
			// (set) Token: 0x060025EC RID: 9708 RVA: 0x00012158 File Offset: 0x00010358
			public unsafe TakeFrom __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeFrom.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TakeFrom>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TakeFrom.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017AB RID: 6059
			private static readonly IntPtr NativeFieldInfoPtr__;

			// Token: 0x040017AC RID: 6060
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017AD RID: 6061
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017AE RID: 6062
			private static readonly IntPtr NativeMethodInfoPtr__PickTargets_b__1_Internal_Boolean_Func_2_Context_Boolean_0;
		}
	}
}
