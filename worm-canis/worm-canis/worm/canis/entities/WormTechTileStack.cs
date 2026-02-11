using System;
using Canis;
using Canis.actions;
using Canis.entities;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.entities
{
	// Token: 0x02000039 RID: 57
	public class WormTechTileStack : WormEntity
	{
		// Token: 0x060004ED RID: 1261 RVA: 0x0007DC38 File Offset: 0x0007BE38
		// Note: this type is marked as 'beforefieldinit'.
		static WormTechTileStack()
		{
			Il2CppClassPointerStore<WormTechTileStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormTechTileStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTechTileStack>.NativeClassPtr);
			WormTechTileStack.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechTileStack>.NativeClassPtr, "wormMatch");
			WormTechTileStack.NativeFieldInfoPtr_stackNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechTileStack>.NativeClassPtr, "stackNumber");
			WormTechTileStack.NativeFieldInfoPtr__TechTileTop_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechTileStack>.NativeClassPtr, "<TechTileTop>k__BackingField");
			WormTechTileStack.NativeFieldInfoPtr__TechTileHidden_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechTileStack>.NativeClassPtr, "<TechTileHidden>k__BackingField");
			WormTechTileStack.NativeMethodInfoPtr_get_TechTileTop_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileStack>.NativeClassPtr, 100664648);
			WormTechTileStack.NativeMethodInfoPtr_set_TechTileTop_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileStack>.NativeClassPtr, 100664649);
			WormTechTileStack.NativeMethodInfoPtr_get_TechTileHidden_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileStack>.NativeClassPtr, 100664650);
			WormTechTileStack.NativeMethodInfoPtr_set_TechTileHidden_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileStack>.NativeClassPtr, 100664651);
			WormTechTileStack.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileStack>.NativeClassPtr, 100664652);
			WormTechTileStack.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileStack>.NativeClassPtr, 100664653);
			WormTechTileStack.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileStack>.NativeClassPtr, 100664654);
			WormTechTileStack.NativeMethodInfoPtr_get_TileCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileStack>.NativeClassPtr, 100664655);
			WormTechTileStack.NativeMethodInfoPtr_get_TopTile_Public_get_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileStack>.NativeClassPtr, 100664656);
			WormTechTileStack.NativeMethodInfoPtr_ShowTopTile_Public_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileStack>.NativeClassPtr, 100664657);
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x0007DD80 File Offset: 0x0007BF80
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x0007DDC0 File Offset: 0x0007BFC0
		public unsafe WormPlayArea TechTileTop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTileStack.NativeMethodInfoPtr_get_TechTileTop_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTileStack.NativeMethodInfoPtr_set_TechTileTop_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x0007DE04 File Offset: 0x0007C004
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x0007DE44 File Offset: 0x0007C044
		public unsafe WormPlayArea TechTileHidden
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTileStack.NativeMethodInfoPtr_get_TechTileHidden_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTileStack.NativeMethodInfoPtr_set_TechTileHidden_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0007DE88 File Offset: 0x0007C088
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48155, RefRangeEnd = 48156, XrefRangeStart = 48094, XrefRangeEnd = 48155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTechTileStack(WormMatch m, int number)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTechTileStack>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTileStack.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0007DEE4 File Offset: 0x0007C0E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48175, RefRangeEnd = 48176, XrefRangeStart = 48156, XrefRangeEnd = 48175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTechTileStack(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTechTileStack>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTileStack.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0007DF54 File Offset: 0x0007C154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48177, RefRangeEnd = 48178, XrefRangeStart = 48176, XrefRangeEnd = 48177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTileStack.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0007DF88 File Offset: 0x0007C188
		public unsafe int TileCount
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 48179, RefRangeEnd = 48183, XrefRangeStart = 48178, XrefRangeEnd = 48179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTileStack.NativeMethodInfoPtr_get_TileCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x0007DFC4 File Offset: 0x0007C1C4
		public unsafe WormTechTilePlayable TopTile
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 48190, RefRangeEnd = 48194, XrefRangeStart = 48183, XrefRangeEnd = 48190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTileStack.NativeMethodInfoPtr_get_TopTile_Public_get_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTechTilePlayable>(intPtr3) : null;
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0007E004 File Offset: 0x0007C204
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48200, RefRangeEnd = 48202, XrefRangeStart = 48194, XrefRangeEnd = 48200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> ShowTopTile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTileStack.NativeMethodInfoPtr_ShowTopTile_Public_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00003CEB File Offset: 0x00001EEB
		public WormTechTileStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x0007E044 File Offset: 0x0007C244
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x00003CF4 File Offset: 0x00001EF4
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechTileStack.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechTileStack.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x0007E074 File Offset: 0x0007C274
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00003D13 File Offset: 0x00001F13
		public unsafe int stackNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechTileStack.NativeFieldInfoPtr_stackNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechTileStack.NativeFieldInfoPtr_stackNumber)) = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x0007E09C File Offset: 0x0007C29C
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x00003D2E File Offset: 0x00001F2E
		public unsafe WormPlayArea _TechTileTop_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechTileStack.NativeFieldInfoPtr__TechTileTop_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechTileStack.NativeFieldInfoPtr__TechTileTop_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x0007E0CC File Offset: 0x0007C2CC
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x00003D4D File Offset: 0x00001F4D
		public unsafe WormPlayArea _TechTileHidden_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechTileStack.NativeFieldInfoPtr__TechTileHidden_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechTileStack.NativeFieldInfoPtr__TechTileHidden_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeFieldInfoPtr_stackNumber;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeFieldInfoPtr__TechTileTop_k__BackingField;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeFieldInfoPtr__TechTileHidden_k__BackingField;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeMethodInfoPtr_get_TechTileTop_Public_get_WormPlayArea_0;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr_set_TechTileTop_Public_set_Void_WormPlayArea_0;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr_get_TechTileHidden_Public_get_WormPlayArea_0;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeMethodInfoPtr_set_TechTileHidden_Public_set_Void_WormPlayArea_0;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_Int32_0;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr_get_TileCount_Public_get_Int32_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_get_TopTile_Public_get_WormTechTilePlayable_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_ShowTopTile_Public_IEnumerable_1_Action_0;

		// Token: 0x020005D6 RID: 1494
		[ObfuscatedName("worm.canis.entities.WormTechTileStack+<ShowTopTile>d__17")]
		public sealed class _ShowTopTile_d__17 : Object
		{
			// Token: 0x0600488E RID: 18574 RVA: 0x0018EF2C File Offset: 0x0018D12C
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowTopTile_d__17()
			{
				Il2CppClassPointerStore<WormTechTileStack._ShowTopTile_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTechTileStack>.NativeClassPtr, "<ShowTopTile>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTechTileStack._ShowTopTile_d__17>.NativeClassPtr);
				WormTechTileStack._ShowTopTile_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechTileStack._ShowTopTile_d__17>.NativeClassPtr, "<>1__state");
				WormTechTileStack._ShowTopTile_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechTileStack._ShowTopTile_d__17>.NativeClassPtr, "<>2__current");
				WormTechTileStack._ShowTopTile_d__17.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechTileStack._ShowTopTile_d__17>.NativeClassPtr, "<>l__initialThreadId");
				WormTechTileStack._ShowTopTile_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechTileStack._ShowTopTile_d__17>.NativeClassPtr, "<>4__this");
				WormTechTileStack._ShowTopTile_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileStack._ShowTopTile_d__17>.NativeClassPtr, 100664658);
				WormTechTileStack._ShowTopTile_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileStack._ShowTopTile_d__17>.NativeClassPtr, 100664659);
				WormTechTileStack._ShowTopTile_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileStack._ShowTopTile_d__17>.NativeClassPtr, 100664660);
				WormTechTileStack._ShowTopTile_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileStack._ShowTopTile_d__17>.NativeClassPtr, 100664661);
				WormTechTileStack._ShowTopTile_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileStack._ShowTopTile_d__17>.NativeClassPtr, 100664662);
				WormTechTileStack._ShowTopTile_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileStack._ShowTopTile_d__17>.NativeClassPtr, 100664663);
				WormTechTileStack._ShowTopTile_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileStack._ShowTopTile_d__17>.NativeClassPtr, 100664664);
				WormTechTileStack._ShowTopTile_d__17.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileStack._ShowTopTile_d__17>.NativeClassPtr, 100664665);
			}

			// Token: 0x0600488F RID: 18575 RVA: 0x0018F048 File Offset: 0x0018D248
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowTopTile_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTechTileStack._ShowTopTile_d__17>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTileStack._ShowTopTile_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004890 RID: 18576 RVA: 0x0018F090 File Offset: 0x0018D290
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTileStack._ShowTopTile_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004891 RID: 18577 RVA: 0x0018F0C4 File Offset: 0x0018D2C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48065, XrefRangeEnd = 48087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTileStack._ShowTopTile_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001192 RID: 4498
			// (get) Token: 0x06004892 RID: 18578 RVA: 0x0018F100 File Offset: 0x0018D300
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTileStack._ShowTopTile_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06004893 RID: 18579 RVA: 0x0018F140 File Offset: 0x0018D340
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48087, XrefRangeEnd = 48092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTileStack._ShowTopTile_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001193 RID: 4499
			// (get) Token: 0x06004894 RID: 18580 RVA: 0x0018F174 File Offset: 0x0018D374
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTileStack._ShowTopTile_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004895 RID: 18581 RVA: 0x0018F1B4 File Offset: 0x0018D3B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48092, XrefRangeEnd = 48094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTileStack._ShowTopTile_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06004896 RID: 18582 RVA: 0x0018F1F4 File Offset: 0x0018D3F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTileStack._ShowTopTile_d__17.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004897 RID: 18583 RVA: 0x0001891D File Offset: 0x00016B1D
			public _ShowTopTile_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700118E RID: 4494
			// (get) Token: 0x06004898 RID: 18584 RVA: 0x0018F234 File Offset: 0x0018D434
			// (set) Token: 0x06004899 RID: 18585 RVA: 0x00018926 File Offset: 0x00016B26
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechTileStack._ShowTopTile_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechTileStack._ShowTopTile_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700118F RID: 4495
			// (get) Token: 0x0600489A RID: 18586 RVA: 0x0018F25C File Offset: 0x0018D45C
			// (set) Token: 0x0600489B RID: 18587 RVA: 0x00018941 File Offset: 0x00016B41
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechTileStack._ShowTopTile_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechTileStack._ShowTopTile_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001190 RID: 4496
			// (get) Token: 0x0600489C RID: 18588 RVA: 0x0018F28C File Offset: 0x0018D48C
			// (set) Token: 0x0600489D RID: 18589 RVA: 0x00018960 File Offset: 0x00016B60
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechTileStack._ShowTopTile_d__17.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechTileStack._ShowTopTile_d__17.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001191 RID: 4497
			// (get) Token: 0x0600489E RID: 18590 RVA: 0x0018F2B4 File Offset: 0x0018D4B4
			// (set) Token: 0x0600489F RID: 18591 RVA: 0x0001897B File Offset: 0x00016B7B
			public unsafe WormTechTileStack __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechTileStack._ShowTopTile_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTechTileStack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechTileStack._ShowTopTile_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002FAF RID: 12207
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002FB0 RID: 12208
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002FB1 RID: 12209
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002FB2 RID: 12210
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002FB3 RID: 12211
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002FB4 RID: 12212
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002FB5 RID: 12213
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002FB6 RID: 12214
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002FB7 RID: 12215
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002FB8 RID: 12216
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002FB9 RID: 12217
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002FBA RID: 12218
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
