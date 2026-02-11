using System;
using Canis.attributes;
using Canis.entities;
using Canis.json.events;
using Canis.obfuscation;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.messages
{
	// Token: 0x0200016D RID: 365
	public class EntityMovedObfuscator : MessageObfuscator<EntityMoved>
	{
		// Token: 0x06001042 RID: 4162 RVA: 0x0005B418 File Offset: 0x00059618
		// Note: this type is marked as 'beforefieldinit'.
		static EntityMovedObfuscator()
		{
			Il2CppClassPointerStore<EntityMovedObfuscator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.messages", "EntityMovedObfuscator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityMovedObfuscator>.NativeClassPtr);
			EntityMovedObfuscator.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedObfuscator>.NativeClassPtr, "Instance");
			EntityMovedObfuscator.NativeMethodInfoPtr_Obfuscate_Public_Virtual_IEnumerable_1_NetworkMessageEvent_EntityMoved_Match_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityMovedObfuscator>.NativeClassPtr, 100666617);
			EntityMovedObfuscator.NativeMethodInfoPtr_FilteredMove_Private_GameMessage_EntityMoved_Entity_AccountID_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityMovedObfuscator>.NativeClassPtr, 100666618);
			EntityMovedObfuscator.NativeMethodInfoPtr_GenMaterializeEntity_Public_Static_MaterializeEntity_Entity_AccountID_EntityMoved_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityMovedObfuscator>.NativeClassPtr, 100666619);
			EntityMovedObfuscator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityMovedObfuscator>.NativeClassPtr, 100666620);
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x0005B4AC File Offset: 0x000596AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579428, XrefRangeEnd = 579436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<NetworkMessageEvent> Obfuscate(EntityMoved message, Match match, PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityMovedObfuscator.NativeMethodInfoPtr_Obfuscate_Public_Virtual_IEnumerable_1_NetworkMessageEvent_EntityMoved_Match_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<NetworkMessageEvent>>(intPtr3) : null;
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0005B52C File Offset: 0x0005972C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 579440, RefRangeEnd = 579441, XrefRangeStart = 579436, XrefRangeEnd = 579440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameMessage FilteredMove(EntityMoved message, Entity movingEntity, AccountID playerID, bool wasHiddenInSource, bool isHiddenInDestination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(movingEntity);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wasHiddenInSource;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHiddenInDestination;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityMovedObfuscator.NativeMethodInfoPtr_FilteredMove_Private_GameMessage_EntityMoved_Entity_AccountID_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameMessage>(intPtr3) : null;
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x0005B5BC File Offset: 0x000597BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 579520, RefRangeEnd = 579521, XrefRangeStart = 579441, XrefRangeEnd = 579520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MaterializeEntity GenMaterializeEntity(Entity entity, AccountID playerID, EntityMoved message = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityMovedObfuscator.NativeMethodInfoPtr_GenMaterializeEntity_Public_Static_MaterializeEntity_Entity_AccountID_EntityMoved_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MaterializeEntity>(intPtr3) : null;
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x0005B624 File Offset: 0x00059824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579521, XrefRangeEnd = 579524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityMovedObfuscator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityMovedObfuscator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityMovedObfuscator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00008444 File Offset: 0x00006644
		public EntityMovedObfuscator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x0005B660 File Offset: 0x00059860
		// (set) Token: 0x06001049 RID: 4169 RVA: 0x0000844D File Offset: 0x0000664D
		public unsafe static EntityMovedObfuscator Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityMovedObfuscator.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityMovedObfuscator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityMovedObfuscator.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeMethodInfoPtr_Obfuscate_Public_Virtual_IEnumerable_1_NetworkMessageEvent_EntityMoved_Match_PlayerEntity_0;

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeMethodInfoPtr_FilteredMove_Private_GameMessage_EntityMoved_Entity_AccountID_Boolean_Boolean_0;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeMethodInfoPtr_GenMaterializeEntity_Public_Static_MaterializeEntity_Entity_AccountID_EntityMoved_0;

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003A6 RID: 934
		[ObfuscatedName("Canis.messages.EntityMovedObfuscator+<Obfuscate>d__1")]
		public sealed class _Obfuscate_d__1 : Object
		{
			// Token: 0x06002712 RID: 10002 RVA: 0x000AB4E8 File Offset: 0x000A96E8
			// Note: this type is marked as 'beforefieldinit'.
			static _Obfuscate_d__1()
			{
				Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityMovedObfuscator>.NativeClassPtr, "<Obfuscate>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr);
				EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>1__state");
				EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>2__current");
				EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>l__initialThreadId");
				EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, "player");
				EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>3__player");
				EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, "match");
				EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>3__match");
				EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, "message");
				EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>3__message");
				EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>4__this");
				EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__playerID_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<playerID>5__2");
				EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__movingEntity_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<movingEntity>5__3");
				EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__sourceParent_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<sourceParent>5__4");
				EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__wasHiddenInSource_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<wasHiddenInSource>5__5");
				EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__destinationParent_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<destinationParent>5__6");
				EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__isHiddenInDestination_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<isHiddenInDestination>5__7");
				EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___7__wrap7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>7__wrap7");
				EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___7__wrap8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, "<>7__wrap8");
				EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666622);
				EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666623);
				EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666624);
				EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666625);
				EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666626);
				EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666627);
				EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr___m__Finally4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666628);
				EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_json_events_NetworkMessageEvent__get_Current_Private_Virtual_Final_New_get_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666629);
				EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666630);
				EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666631);
				EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666632);
				EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr, 100666633);
			}

			// Token: 0x06002713 RID: 10003 RVA: 0x000AB76C File Offset: 0x000A996C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Obfuscate_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityMovedObfuscator._Obfuscate_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002714 RID: 10004 RVA: 0x000AB7B4 File Offset: 0x000A99B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579246, XrefRangeEnd = 579258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002715 RID: 10005 RVA: 0x000AB7E8 File Offset: 0x000A99E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579258, XrefRangeEnd = 579400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002716 RID: 10006 RVA: 0x000AB824 File Offset: 0x000A9A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579400, XrefRangeEnd = 579403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002717 RID: 10007 RVA: 0x000AB858 File Offset: 0x000A9A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579403, XrefRangeEnd = 579406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002718 RID: 10008 RVA: 0x000AB88C File Offset: 0x000A9A8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579406, XrefRangeEnd = 579409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002719 RID: 10009 RVA: 0x000AB8C0 File Offset: 0x000A9AC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579409, XrefRangeEnd = 579412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr___m__Finally4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009C2 RID: 2498
			// (get) Token: 0x0600271A RID: 10010 RVA: 0x000AB8F4 File Offset: 0x000A9AF4
			public unsafe NetworkMessageEvent System.Collections.Generic.IEnumerator<Canis.json.events.NetworkMessageEvent>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_json_events_NetworkMessageEvent__get_Current_Private_Virtual_Final_New_get_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr3) : null;
				}
			}

			// Token: 0x0600271B RID: 10011 RVA: 0x000AB934 File Offset: 0x000A9B34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579412, XrefRangeEnd = 579417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009C3 RID: 2499
			// (get) Token: 0x0600271C RID: 10012 RVA: 0x000AB968 File Offset: 0x000A9B68
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600271D RID: 10013 RVA: 0x000AB9A8 File Offset: 0x000A9BA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 579417, XrefRangeEnd = 579428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<NetworkMessageEvent> System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<NetworkMessageEvent>>(intPtr3) : null;
			}

			// Token: 0x0600271E RID: 10014 RVA: 0x000AB9E8 File Offset: 0x000A9BE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityMovedObfuscator._Obfuscate_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600271F RID: 10015 RVA: 0x00012AD8 File Offset: 0x00010CD8
			public _Obfuscate_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009B0 RID: 2480
			// (get) Token: 0x06002720 RID: 10016 RVA: 0x000ABA28 File Offset: 0x000A9C28
			// (set) Token: 0x06002721 RID: 10017 RVA: 0x00012AE1 File Offset: 0x00010CE1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009B1 RID: 2481
			// (get) Token: 0x06002722 RID: 10018 RVA: 0x000ABA50 File Offset: 0x000A9C50
			// (set) Token: 0x06002723 RID: 10019 RVA: 0x00012AFC File Offset: 0x00010CFC
			public unsafe NetworkMessageEvent __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B2 RID: 2482
			// (get) Token: 0x06002724 RID: 10020 RVA: 0x000ABA80 File Offset: 0x000A9C80
			// (set) Token: 0x06002725 RID: 10021 RVA: 0x00012B1B File Offset: 0x00010D1B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170009B3 RID: 2483
			// (get) Token: 0x06002726 RID: 10022 RVA: 0x000ABAA8 File Offset: 0x000A9CA8
			// (set) Token: 0x06002727 RID: 10023 RVA: 0x00012B36 File Offset: 0x00010D36
			public unsafe PlayerEntity player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B4 RID: 2484
			// (get) Token: 0x06002728 RID: 10024 RVA: 0x000ABAD8 File Offset: 0x000A9CD8
			// (set) Token: 0x06002729 RID: 10025 RVA: 0x00012B55 File Offset: 0x00010D55
			public unsafe PlayerEntity __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B5 RID: 2485
			// (get) Token: 0x0600272A RID: 10026 RVA: 0x000ABB08 File Offset: 0x000A9D08
			// (set) Token: 0x0600272B RID: 10027 RVA: 0x00012B74 File Offset: 0x00010D74
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B6 RID: 2486
			// (get) Token: 0x0600272C RID: 10028 RVA: 0x000ABB38 File Offset: 0x000A9D38
			// (set) Token: 0x0600272D RID: 10029 RVA: 0x00012B93 File Offset: 0x00010D93
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B7 RID: 2487
			// (get) Token: 0x0600272E RID: 10030 RVA: 0x000ABB68 File Offset: 0x000A9D68
			// (set) Token: 0x0600272F RID: 10031 RVA: 0x00012BB2 File Offset: 0x00010DB2
			public unsafe EntityMoved message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityMoved>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B8 RID: 2488
			// (get) Token: 0x06002730 RID: 10032 RVA: 0x000ABB98 File Offset: 0x000A9D98
			// (set) Token: 0x06002731 RID: 10033 RVA: 0x00012BD1 File Offset: 0x00010DD1
			public unsafe EntityMoved __3__message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityMoved>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___3__message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B9 RID: 2489
			// (get) Token: 0x06002732 RID: 10034 RVA: 0x000ABBC8 File Offset: 0x000A9DC8
			// (set) Token: 0x06002733 RID: 10035 RVA: 0x00012BF0 File Offset: 0x00010DF0
			public unsafe EntityMovedObfuscator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityMovedObfuscator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009BA RID: 2490
			// (get) Token: 0x06002734 RID: 10036 RVA: 0x000ABBF8 File Offset: 0x000A9DF8
			// (set) Token: 0x06002735 RID: 10037 RVA: 0x00012C0F File Offset: 0x00010E0F
			public unsafe AccountID _playerID_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__playerID_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__playerID_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009BB RID: 2491
			// (get) Token: 0x06002736 RID: 10038 RVA: 0x000ABC28 File Offset: 0x000A9E28
			// (set) Token: 0x06002737 RID: 10039 RVA: 0x00012C2E File Offset: 0x00010E2E
			public unsafe Entity _movingEntity_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__movingEntity_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__movingEntity_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009BC RID: 2492
			// (get) Token: 0x06002738 RID: 10040 RVA: 0x000ABC58 File Offset: 0x000A9E58
			// (set) Token: 0x06002739 RID: 10041 RVA: 0x00012C4D File Offset: 0x00010E4D
			public unsafe Entity _sourceParent_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__sourceParent_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__sourceParent_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009BD RID: 2493
			// (get) Token: 0x0600273A RID: 10042 RVA: 0x000ABC88 File Offset: 0x000A9E88
			// (set) Token: 0x0600273B RID: 10043 RVA: 0x00012C6C File Offset: 0x00010E6C
			public unsafe bool _wasHiddenInSource_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__wasHiddenInSource_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__wasHiddenInSource_5__5)) = value;
				}
			}

			// Token: 0x170009BE RID: 2494
			// (get) Token: 0x0600273C RID: 10044 RVA: 0x000ABCB0 File Offset: 0x000A9EB0
			// (set) Token: 0x0600273D RID: 10045 RVA: 0x00012C87 File Offset: 0x00010E87
			public unsafe Entity _destinationParent_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__destinationParent_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__destinationParent_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009BF RID: 2495
			// (get) Token: 0x0600273E RID: 10046 RVA: 0x000ABCE0 File Offset: 0x000A9EE0
			// (set) Token: 0x0600273F RID: 10047 RVA: 0x00012CA6 File Offset: 0x00010EA6
			public unsafe bool _isHiddenInDestination_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__isHiddenInDestination_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr__isHiddenInDestination_5__7)) = value;
				}
			}

			// Token: 0x170009C0 RID: 2496
			// (get) Token: 0x06002740 RID: 10048 RVA: 0x000ABD08 File Offset: 0x000A9F08
			// (set) Token: 0x06002741 RID: 10049 RVA: 0x00012CC1 File Offset: 0x00010EC1
			public unsafe IEnumerator<IAttribute<Nullable<int>>> __7__wrap7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___7__wrap7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute<Nullable<int>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___7__wrap7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009C1 RID: 2497
			// (get) Token: 0x06002742 RID: 10050 RVA: 0x000ABD38 File Offset: 0x000A9F38
			// (set) Token: 0x06002743 RID: 10051 RVA: 0x00012CE0 File Offset: 0x00010EE0
			public unsafe IEnumerator<NetworkMessageEvent> __7__wrap8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___7__wrap8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<NetworkMessageEvent>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedObfuscator._Obfuscate_d__1.NativeFieldInfoPtr___7__wrap8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001860 RID: 6240
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001861 RID: 6241
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001862 RID: 6242
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001863 RID: 6243
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04001864 RID: 6244
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04001865 RID: 6245
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001866 RID: 6246
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04001867 RID: 6247
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04001868 RID: 6248
			private static readonly IntPtr NativeFieldInfoPtr___3__message;

			// Token: 0x04001869 RID: 6249
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400186A RID: 6250
			private static readonly IntPtr NativeFieldInfoPtr__playerID_5__2;

			// Token: 0x0400186B RID: 6251
			private static readonly IntPtr NativeFieldInfoPtr__movingEntity_5__3;

			// Token: 0x0400186C RID: 6252
			private static readonly IntPtr NativeFieldInfoPtr__sourceParent_5__4;

			// Token: 0x0400186D RID: 6253
			private static readonly IntPtr NativeFieldInfoPtr__wasHiddenInSource_5__5;

			// Token: 0x0400186E RID: 6254
			private static readonly IntPtr NativeFieldInfoPtr__destinationParent_5__6;

			// Token: 0x0400186F RID: 6255
			private static readonly IntPtr NativeFieldInfoPtr__isHiddenInDestination_5__7;

			// Token: 0x04001870 RID: 6256
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap7;

			// Token: 0x04001871 RID: 6257
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap8;

			// Token: 0x04001872 RID: 6258
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001873 RID: 6259
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001874 RID: 6260
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001875 RID: 6261
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001876 RID: 6262
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04001877 RID: 6263
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x04001878 RID: 6264
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally4_Private_Void_0;

			// Token: 0x04001879 RID: 6265
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_json_events_NetworkMessageEvent__get_Current_Private_Virtual_Final_New_get_NetworkMessageEvent_0;

			// Token: 0x0400187A RID: 6266
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400187B RID: 6267
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400187C RID: 6268
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_NetworkMessageEvent_0;

			// Token: 0x0400187D RID: 6269
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
