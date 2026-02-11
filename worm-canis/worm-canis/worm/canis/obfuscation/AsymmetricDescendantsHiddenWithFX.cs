using System;
using Canis;
using Canis.json.events;
using Canis.messages;
using Canis.obfuscation;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.obfuscation
{
	// Token: 0x02000013 RID: 19
	public class AsymmetricDescendantsHiddenWithFX : AsymmetricDescendantsHidden
	{
		// Token: 0x06000106 RID: 262 RVA: 0x0006E330 File Offset: 0x0006C530
		// Note: this type is marked as 'beforefieldinit'.
		static AsymmetricDescendantsHiddenWithFX()
		{
			Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.obfuscation", "AsymmetricDescendantsHiddenWithFX");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX>.NativeClassPtr);
			AsymmetricDescendantsHiddenWithFX.NativeFieldInfoPtr_FXLocationGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX>.NativeClassPtr, "FXLocationGenerator");
			AsymmetricDescendantsHiddenWithFX.NativeFieldInfoPtr_IncrementFXName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX>.NativeClassPtr, "IncrementFXName");
			AsymmetricDescendantsHiddenWithFX.NativeFieldInfoPtr_DecrementFXName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX>.NativeClassPtr, "DecrementFXName");
			AsymmetricDescendantsHiddenWithFX.NativeMethodInfoPtr_PostMove_Public_Virtual_IEnumerable_1_NetworkMessageEvent_EntityMoved_EntityID_AccountID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX>.NativeClassPtr, 100663746);
			AsymmetricDescendantsHiddenWithFX.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX>.NativeClassPtr, 100663747);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0006E3C4 File Offset: 0x0006C5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31178, XrefRangeEnd = 31187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<NetworkMessageEvent> PostMove(EntityMoved entityMoved, EntityID parentID, AccountID perspective, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityMoved);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(perspective);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsymmetricDescendantsHiddenWithFX.NativeMethodInfoPtr_PostMove_Public_Virtual_IEnumerable_1_NetworkMessageEvent_EntityMoved_EntityID_AccountID_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<NetworkMessageEvent>>(intPtr3) : null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0006E458 File Offset: 0x0006C658
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31188, RefRangeEnd = 31189, XrefRangeStart = 31187, XrefRangeEnd = 31188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsymmetricDescendantsHiddenWithFX()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricDescendantsHiddenWithFX.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002405 File Offset: 0x00000605
		public AsymmetricDescendantsHiddenWithFX(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0006E494 File Offset: 0x0006C694
		// (set) Token: 0x0600010B RID: 267 RVA: 0x0000240E File Offset: 0x0000060E
		public unsafe FXLocationGenerator FXLocationGenerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX.NativeFieldInfoPtr_FXLocationGenerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FXLocationGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX.NativeFieldInfoPtr_FXLocationGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600010C RID: 268 RVA: 0x0006E4C4 File Offset: 0x0006C6C4
		// (set) Token: 0x0600010D RID: 269 RVA: 0x0000242D File Offset: 0x0000062D
		public unsafe string IncrementFXName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX.NativeFieldInfoPtr_IncrementFXName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX.NativeFieldInfoPtr_IncrementFXName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600010E RID: 270 RVA: 0x0006E4EC File Offset: 0x0006C6EC
		// (set) Token: 0x0600010F RID: 271 RVA: 0x0000244C File Offset: 0x0000064C
		public unsafe string DecrementFXName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX.NativeFieldInfoPtr_DecrementFXName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX.NativeFieldInfoPtr_DecrementFXName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr_FXLocationGenerator;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_IncrementFXName;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_DecrementFXName;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_PostMove_Public_Virtual_IEnumerable_1_NetworkMessageEvent_EntityMoved_EntityID_AccountID_Match_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000587 RID: 1415
		[ObfuscatedName("worm.canis.obfuscation.AsymmetricDescendantsHiddenWithFX+<PostMove>d__3")]
		public new sealed class _PostMove_d__3 : Object
		{
			// Token: 0x060043D1 RID: 17361 RVA: 0x00180840 File Offset: 0x0017EA40
			// Note: this type is marked as 'beforefieldinit'.
			static _PostMove_d__3()
			{
				Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX._PostMove_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX>.NativeClassPtr, "<PostMove>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX._PostMove_d__3>.NativeClassPtr);
				AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX._PostMove_d__3>.NativeClassPtr, "<>1__state");
				AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX._PostMove_d__3>.NativeClassPtr, "<>2__current");
				AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX._PostMove_d__3>.NativeClassPtr, "<>l__initialThreadId");
				AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr_entityMoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX._PostMove_d__3>.NativeClassPtr, "entityMoved");
				AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr___3__entityMoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX._PostMove_d__3>.NativeClassPtr, "<>3__entityMoved");
				AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr_parentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX._PostMove_d__3>.NativeClassPtr, "parentID");
				AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr___3__parentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX._PostMove_d__3>.NativeClassPtr, "<>3__parentID");
				AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX._PostMove_d__3>.NativeClassPtr, "<>4__this");
				AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX._PostMove_d__3>.NativeClassPtr, "match");
				AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX._PostMove_d__3>.NativeClassPtr, "<>3__match");
				AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX._PostMove_d__3>.NativeClassPtr, 100663748);
				AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX._PostMove_d__3>.NativeClassPtr, 100663749);
				AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX._PostMove_d__3>.NativeClassPtr, 100663750);
				AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_json_events_NetworkMessageEvent__get_Current_Private_Virtual_Final_New_get_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX._PostMove_d__3>.NativeClassPtr, 100663751);
				AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX._PostMove_d__3>.NativeClassPtr, 100663752);
				AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX._PostMove_d__3>.NativeClassPtr, 100663753);
				AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX._PostMove_d__3>.NativeClassPtr, 100663754);
				AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX._PostMove_d__3>.NativeClassPtr, 100663755);
			}

			// Token: 0x060043D2 RID: 17362 RVA: 0x001809D4 File Offset: 0x0017EBD4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PostMove_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsymmetricDescendantsHiddenWithFX._PostMove_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060043D3 RID: 17363 RVA: 0x00180A1C File Offset: 0x0017EC1C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060043D4 RID: 17364 RVA: 0x00180A50 File Offset: 0x0017EC50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31144, XrefRangeEnd = 31162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001019 RID: 4121
			// (get) Token: 0x060043D5 RID: 17365 RVA: 0x00180A8C File Offset: 0x0017EC8C
			public unsafe NetworkMessageEvent System.Collections.Generic.IEnumerator<Canis.json.events.NetworkMessageEvent>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_json_events_NetworkMessageEvent__get_Current_Private_Virtual_Final_New_get_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr3) : null;
				}
			}

			// Token: 0x060043D6 RID: 17366 RVA: 0x00180ACC File Offset: 0x0017ECCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31162, XrefRangeEnd = 31167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700101A RID: 4122
			// (get) Token: 0x060043D7 RID: 17367 RVA: 0x00180B00 File Offset: 0x0017ED00
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060043D8 RID: 17368 RVA: 0x00180B40 File Offset: 0x0017ED40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31167, XrefRangeEnd = 31178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<NetworkMessageEvent> System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<NetworkMessageEvent>>(intPtr3) : null;
			}

			// Token: 0x060043D9 RID: 17369 RVA: 0x00180B80 File Offset: 0x0017ED80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060043DA RID: 17370 RVA: 0x000162A7 File Offset: 0x000144A7
			public _PostMove_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700100F RID: 4111
			// (get) Token: 0x060043DB RID: 17371 RVA: 0x00180BC0 File Offset: 0x0017EDC0
			// (set) Token: 0x060043DC RID: 17372 RVA: 0x000162B0 File Offset: 0x000144B0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001010 RID: 4112
			// (get) Token: 0x060043DD RID: 17373 RVA: 0x00180BE8 File Offset: 0x0017EDE8
			// (set) Token: 0x060043DE RID: 17374 RVA: 0x000162CB File Offset: 0x000144CB
			public unsafe NetworkMessageEvent __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001011 RID: 4113
			// (get) Token: 0x060043DF RID: 17375 RVA: 0x00180C18 File Offset: 0x0017EE18
			// (set) Token: 0x060043E0 RID: 17376 RVA: 0x000162EA File Offset: 0x000144EA
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001012 RID: 4114
			// (get) Token: 0x060043E1 RID: 17377 RVA: 0x00180C40 File Offset: 0x0017EE40
			// (set) Token: 0x060043E2 RID: 17378 RVA: 0x00016305 File Offset: 0x00014505
			public unsafe EntityMoved entityMoved
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr_entityMoved);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityMoved>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr_entityMoved), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001013 RID: 4115
			// (get) Token: 0x060043E3 RID: 17379 RVA: 0x00180C70 File Offset: 0x0017EE70
			// (set) Token: 0x060043E4 RID: 17380 RVA: 0x00016324 File Offset: 0x00014524
			public unsafe EntityMoved __3__entityMoved
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr___3__entityMoved);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityMoved>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr___3__entityMoved), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001014 RID: 4116
			// (get) Token: 0x060043E5 RID: 17381 RVA: 0x00180CA0 File Offset: 0x0017EEA0
			// (set) Token: 0x060043E6 RID: 17382 RVA: 0x00016343 File Offset: 0x00014543
			public unsafe EntityID parentID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr_parentID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr_parentID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001015 RID: 4117
			// (get) Token: 0x060043E7 RID: 17383 RVA: 0x00180CD0 File Offset: 0x0017EED0
			// (set) Token: 0x060043E8 RID: 17384 RVA: 0x00016362 File Offset: 0x00014562
			public unsafe EntityID __3__parentID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr___3__parentID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr___3__parentID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001016 RID: 4118
			// (get) Token: 0x060043E9 RID: 17385 RVA: 0x00180D00 File Offset: 0x0017EF00
			// (set) Token: 0x060043EA RID: 17386 RVA: 0x00016381 File Offset: 0x00014581
			public unsafe AsymmetricDescendantsHiddenWithFX __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsymmetricDescendantsHiddenWithFX>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001017 RID: 4119
			// (get) Token: 0x060043EB RID: 17387 RVA: 0x00180D30 File Offset: 0x0017EF30
			// (set) Token: 0x060043EC RID: 17388 RVA: 0x000163A0 File Offset: 0x000145A0
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001018 RID: 4120
			// (get) Token: 0x060043ED RID: 17389 RVA: 0x00180D60 File Offset: 0x0017EF60
			// (set) Token: 0x060043EE RID: 17390 RVA: 0x000163BF File Offset: 0x000145BF
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHiddenWithFX._PostMove_d__3.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002CD5 RID: 11477
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002CD6 RID: 11478
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002CD7 RID: 11479
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002CD8 RID: 11480
			private static readonly IntPtr NativeFieldInfoPtr_entityMoved;

			// Token: 0x04002CD9 RID: 11481
			private static readonly IntPtr NativeFieldInfoPtr___3__entityMoved;

			// Token: 0x04002CDA RID: 11482
			private static readonly IntPtr NativeFieldInfoPtr_parentID;

			// Token: 0x04002CDB RID: 11483
			private static readonly IntPtr NativeFieldInfoPtr___3__parentID;

			// Token: 0x04002CDC RID: 11484
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002CDD RID: 11485
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04002CDE RID: 11486
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04002CDF RID: 11487
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002CE0 RID: 11488
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002CE1 RID: 11489
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002CE2 RID: 11490
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_json_events_NetworkMessageEvent__get_Current_Private_Virtual_Final_New_get_NetworkMessageEvent_0;

			// Token: 0x04002CE3 RID: 11491
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002CE4 RID: 11492
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002CE5 RID: 11493
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_NetworkMessageEvent_0;

			// Token: 0x04002CE6 RID: 11494
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
