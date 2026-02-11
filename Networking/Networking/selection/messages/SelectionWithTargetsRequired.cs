using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetinformation;

namespace Networking.selection.messages
{
	// Token: 0x02000083 RID: 131
	public class SelectionWithTargetsRequired : SelectionMessage
	{
		// Token: 0x06000465 RID: 1125 RVA: 0x00011A40 File Offset: 0x0000FC40
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionWithTargetsRequired()
		{
			Il2CppClassPointerStore<SelectionWithTargetsRequired>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.messages", "SelectionWithTargetsRequired");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionWithTargetsRequired>.NativeClassPtr);
			SelectionWithTargetsRequired.NativeFieldInfoPtr_TargetMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsRequired>.NativeClassPtr, "TargetMap");
			SelectionWithTargetsRequired.NativeFieldInfoPtr_TargetPreferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsRequired>.NativeClassPtr, "TargetPreferences");
			SelectionWithTargetsRequired.NativeFieldInfoPtr_Forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsRequired>.NativeClassPtr, "Forced");
			SelectionWithTargetsRequired.NativeFieldInfoPtr_TargetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsRequired>.NativeClassPtr, "TargetType");
			SelectionWithTargetsRequired.NativeFieldInfoPtr_IgnoreFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsRequired>.NativeClassPtr, "IgnoreFirst");
			SelectionWithTargetsRequired.NativeFieldInfoPtr_SelectionParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsRequired>.NativeClassPtr, "SelectionParams");
			SelectionWithTargetsRequired.NativeFieldInfoPtr_SourceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsRequired>.NativeClassPtr, "SourceID");
			SelectionWithTargetsRequired.NativeMethodInfoPtr_get_Params_Public_Virtual_Final_New_get_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsRequired>.NativeClassPtr, 100663580);
			SelectionWithTargetsRequired.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsRequired>.NativeClassPtr, 100663581);
			SelectionWithTargetsRequired.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsRequired>.NativeClassPtr, 100663582);
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00011B38 File Offset: 0x0000FD38
		public unsafe virtual Dictionary<string, Object> Params
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsRequired.NativeMethodInfoPtr_get_Params_Public_Virtual_Final_New_get_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00011B78 File Offset: 0x0000FD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194594, XrefRangeEnd = 1194643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionWithTargetsRequired.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00011BBC File Offset: 0x0000FDBC
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionWithTargetsRequired()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionWithTargetsRequired>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsRequired.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00004B73 File Offset: 0x00002D73
		public SelectionWithTargetsRequired(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x00011BF8 File Offset: 0x0000FDF8
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x00004B7C File Offset: 0x00002D7C
		public unsafe Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>> TargetMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsRequired.NativeFieldInfoPtr_TargetMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsRequired.NativeFieldInfoPtr_TargetMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00011C28 File Offset: 0x0000FE28
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00004B9B File Offset: 0x00002D9B
		public unsafe Il2CppReferenceArray<Tuple<EntityID, TargetPreference>> TargetPreferences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsRequired.NativeFieldInfoPtr_TargetPreferences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Tuple<EntityID, TargetPreference>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsRequired.NativeFieldInfoPtr_TargetPreferences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x00011C58 File Offset: 0x0000FE58
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x00004BBA File Offset: 0x00002DBA
		public unsafe bool Forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsRequired.NativeFieldInfoPtr_Forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsRequired.NativeFieldInfoPtr_Forced)) = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x00011C80 File Offset: 0x0000FE80
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x00004BD5 File Offset: 0x00002DD5
		public unsafe string TargetType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsRequired.NativeFieldInfoPtr_TargetType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsRequired.NativeFieldInfoPtr_TargetType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x00011CA8 File Offset: 0x0000FEA8
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x00004BF4 File Offset: 0x00002DF4
		public unsafe bool IgnoreFirst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsRequired.NativeFieldInfoPtr_IgnoreFirst);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsRequired.NativeFieldInfoPtr_IgnoreFirst)) = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x00011CD0 File Offset: 0x0000FED0
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x00004C0F File Offset: 0x00002E0F
		public unsafe Dictionary<string, Object> SelectionParams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsRequired.NativeFieldInfoPtr_SelectionParams);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsRequired.NativeFieldInfoPtr_SelectionParams), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x00011D00 File Offset: 0x0000FF00
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x00004C2E File Offset: 0x00002E2E
		public unsafe EntityID SourceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsRequired.NativeFieldInfoPtr_SourceID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsRequired.NativeFieldInfoPtr_SourceID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeFieldInfoPtr_TargetMap;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeFieldInfoPtr_TargetPreferences;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeFieldInfoPtr_Forced;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeFieldInfoPtr_TargetType;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreFirst;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeFieldInfoPtr_SelectionParams;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeFieldInfoPtr_SourceID;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_get_Params_Public_Virtual_Final_New_get_Dictionary_2_String_Object_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000CA RID: 202
		[ObfuscatedName("Networking.selection.messages.SelectionWithTargetsRequired+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600068C RID: 1676 RVA: 0x000171B4 File Offset: 0x000153B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SelectionWithTargetsRequired.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectionWithTargetsRequired>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionWithTargetsRequired.__c>.NativeClassPtr);
				SelectionWithTargetsRequired.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsRequired.__c>.NativeClassPtr, "<>9");
				SelectionWithTargetsRequired.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsRequired.__c>.NativeClassPtr, "<>9__9_0");
				SelectionWithTargetsRequired.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsRequired.__c>.NativeClassPtr, 100663584);
				SelectionWithTargetsRequired.__c.NativeMethodInfoPtr__ToString_b__9_0_Internal_String_KeyValuePair_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsRequired.__c>.NativeClassPtr, 100663585);
			}

			// Token: 0x0600068D RID: 1677 RVA: 0x00017230 File Offset: 0x00015430
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionWithTargetsRequired.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsRequired.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600068E RID: 1678 RVA: 0x0001726C File Offset: 0x0001546C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194551, XrefRangeEnd = 1194594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__9_0(KeyValuePair<EntityID, Il2CppReferenceArray<TargetInformation>> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsRequired.__c.NativeMethodInfoPtr__ToString_b__9_0_Internal_String_KeyValuePair_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600068F RID: 1679 RVA: 0x000060E3 File Offset: 0x000042E3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001E4 RID: 484
			// (get) Token: 0x06000690 RID: 1680 RVA: 0x000172BC File Offset: 0x000154BC
			// (set) Token: 0x06000691 RID: 1681 RVA: 0x000060EC File Offset: 0x000042EC
			public unsafe static SelectionWithTargetsRequired.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectionWithTargetsRequired.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionWithTargetsRequired.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectionWithTargetsRequired.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001E5 RID: 485
			// (get) Token: 0x06000692 RID: 1682 RVA: 0x000172E4 File Offset: 0x000154E4
			// (set) Token: 0x06000693 RID: 1683 RVA: 0x000060FE File Offset: 0x000042FE
			public unsafe static Func<KeyValuePair<EntityID, Il2CppReferenceArray<TargetInformation>>, string> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectionWithTargetsRequired.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<EntityID, Il2CppReferenceArray<TargetInformation>>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectionWithTargetsRequired.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000366 RID: 870
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000367 RID: 871
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04000368 RID: 872
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000369 RID: 873
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__9_0_Internal_String_KeyValuePair_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0;
		}
	}
}
