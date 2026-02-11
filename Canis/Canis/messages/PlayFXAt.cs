using System;
using System.Runtime.InteropServices;
using Canis.actions;
using Canis.attributes;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis.messages
{
	// Token: 0x02000164 RID: 356
	public class PlayFXAt : Canis.actions.Action
	{
		// Token: 0x06001008 RID: 4104 RVA: 0x0005A7E4 File Offset: 0x000589E4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayFXAt()
		{
			Il2CppClassPointerStore<PlayFXAt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.messages", "PlayFXAt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayFXAt>.NativeClassPtr);
			PlayFXAt.NativeFieldInfoPtr_fxName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFXAt>.NativeClassPtr, "fxName");
			PlayFXAt.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFXAt>.NativeClassPtr, "attributes");
			PlayFXAt.NativeFieldInfoPtr_forPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFXAt>.NativeClassPtr, "forPlayers");
			PlayFXAt.NativeMethodInfoPtr__ctor_Public_Void_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXAt>.NativeClassPtr, 100666565);
			PlayFXAt.NativeMethodInfoPtr_WithAttribute_Public_PlayFXAt_AttributeDefinition_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXAt>.NativeClassPtr, 100666566);
			PlayFXAt.NativeMethodInfoPtr_ForPlayers_Public_PlayFXAt_IEnumerable_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXAt>.NativeClassPtr, 100666567);
			PlayFXAt.NativeMethodInfoPtr_ForPlayers_Public_PlayFXAt_Il2CppReferenceArray_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXAt>.NativeClassPtr, 100666568);
			PlayFXAt.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXAt>.NativeClassPtr, 100666569);
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x0005A8B4 File Offset: 0x00058AB4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 578918, RefRangeEnd = 578925, XrefRangeStart = 578915, XrefRangeEnd = 578918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayFXAt(string fxName, Match match)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayFXAt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fxName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXAt.NativeMethodInfoPtr__ctor_Public_Void_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x0005A914 File Offset: 0x00058B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578925, XrefRangeEnd = 578933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayFXAt WithAttribute<T>(AttributeDefinition<T> attribute, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PlayFXAt.MethodInfoStoreGeneric_WithAttribute_Public_PlayFXAt_AttributeDefinition_1_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<PlayFXAt>(intPtr4) : null;
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x0005A9AC File Offset: 0x00058BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578933, XrefRangeEnd = 578937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayFXAt ForPlayers(IEnumerable<PlayerEntity> players)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(players);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXAt.NativeMethodInfoPtr_ForPlayers_Public_PlayFXAt_IEnumerable_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayFXAt>(intPtr3) : null;
			}
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0005A9FC File Offset: 0x00058BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayFXAt ForPlayers([Optional] Il2CppReferenceArray<PlayerEntity> players)
		{
			if (players == null)
			{
				players = new Il2CppReferenceArray<PlayerEntity>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(players);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXAt.NativeMethodInfoPtr_ForPlayers_Public_PlayFXAt_Il2CppReferenceArray_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayFXAt>(intPtr3) : null;
			}
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0005AA5C File Offset: 0x00058C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578937, XrefRangeEnd = 578943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayFXAt.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x000082C4 File Offset: 0x000064C4
		public PlayFXAt ForPlayers(params PlayerEntity[] players)
		{
			return this.ForPlayers(new Il2CppReferenceArray<PlayerEntity>(players));
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x000082D2 File Offset: 0x000064D2
		public PlayFXAt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x0005AAA8 File Offset: 0x00058CA8
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x000082DB File Offset: 0x000064DB
		public unsafe string fxName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXAt.NativeFieldInfoPtr_fxName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXAt.NativeFieldInfoPtr_fxName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x0005AAD0 File Offset: 0x00058CD0
		// (set) Token: 0x06001013 RID: 4115 RVA: 0x000082FA File Offset: 0x000064FA
		public unsafe MutableAttributes attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXAt.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXAt.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x0005AB00 File Offset: 0x00058D00
		// (set) Token: 0x06001015 RID: 4117 RVA: 0x00008319 File Offset: 0x00006519
		public unsafe Il2CppReferenceArray<PlayerEntity> forPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXAt.NativeFieldInfoPtr_forPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXAt.NativeFieldInfoPtr_forPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeFieldInfoPtr_fxName;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeFieldInfoPtr_forPlayers;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Match_0;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeMethodInfoPtr_WithAttribute_Public_PlayFXAt_AttributeDefinition_1_T_T_0;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeMethodInfoPtr_ForPlayers_Public_PlayFXAt_IEnumerable_1_PlayerEntity_0;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeMethodInfoPtr_ForPlayers_Public_PlayFXAt_Il2CppReferenceArray_1_PlayerEntity_0;

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x020003A2 RID: 930
		[ObfuscatedName("Canis.messages.PlayFXAt+<execute>d__7")]
		public sealed class _execute_d__7 : Object
		{
			// Token: 0x060026B2 RID: 9906 RVA: 0x000AA388 File Offset: 0x000A8588
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__7()
			{
				Il2CppClassPointerStore<PlayFXAt._execute_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayFXAt>.NativeClassPtr, "<execute>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayFXAt._execute_d__7>.NativeClassPtr);
				PlayFXAt._execute_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFXAt._execute_d__7>.NativeClassPtr, "<>1__state");
				PlayFXAt._execute_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFXAt._execute_d__7>.NativeClassPtr, "<>2__current");
				PlayFXAt._execute_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFXAt._execute_d__7>.NativeClassPtr, "<>l__initialThreadId");
				PlayFXAt._execute_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFXAt._execute_d__7>.NativeClassPtr, "<>4__this");
				PlayFXAt._execute_d__7.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFXAt._execute_d__7>.NativeClassPtr, "<>7__wrap1");
				PlayFXAt._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXAt._execute_d__7>.NativeClassPtr, 100666570);
				PlayFXAt._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXAt._execute_d__7>.NativeClassPtr, 100666571);
				PlayFXAt._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXAt._execute_d__7>.NativeClassPtr, 100666572);
				PlayFXAt._execute_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXAt._execute_d__7>.NativeClassPtr, 100666573);
				PlayFXAt._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXAt._execute_d__7>.NativeClassPtr, 100666574);
				PlayFXAt._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXAt._execute_d__7>.NativeClassPtr, 100666575);
				PlayFXAt._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXAt._execute_d__7>.NativeClassPtr, 100666576);
				PlayFXAt._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXAt._execute_d__7>.NativeClassPtr, 100666577);
				PlayFXAt._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXAt._execute_d__7>.NativeClassPtr, 100666578);
			}

			// Token: 0x060026B3 RID: 9907 RVA: 0x000AA4CC File Offset: 0x000A86CC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayFXAt._execute_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXAt._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060026B4 RID: 9908 RVA: 0x000AA514 File Offset: 0x000A8714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578863, XrefRangeEnd = 578868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXAt._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026B5 RID: 9909 RVA: 0x000AA548 File Offset: 0x000A8748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578868, XrefRangeEnd = 578905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXAt._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060026B6 RID: 9910 RVA: 0x000AA584 File Offset: 0x000A8784
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578905, XrefRangeEnd = 578908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXAt._execute_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000990 RID: 2448
			// (get) Token: 0x060026B7 RID: 9911 RVA: 0x000AA5B8 File Offset: 0x000A87B8
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXAt._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060026B8 RID: 9912 RVA: 0x000AA5F8 File Offset: 0x000A87F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578908, XrefRangeEnd = 578913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXAt._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000991 RID: 2449
			// (get) Token: 0x060026B9 RID: 9913 RVA: 0x000AA62C File Offset: 0x000A882C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXAt._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026BA RID: 9914 RVA: 0x000AA66C File Offset: 0x000A886C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578913, XrefRangeEnd = 578915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXAt._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060026BB RID: 9915 RVA: 0x000AA6AC File Offset: 0x000A88AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXAt._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060026BC RID: 9916 RVA: 0x00012714 File Offset: 0x00010914
			public _execute_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700098B RID: 2443
			// (get) Token: 0x060026BD RID: 9917 RVA: 0x000AA6EC File Offset: 0x000A88EC
			// (set) Token: 0x060026BE RID: 9918 RVA: 0x0001271D File Offset: 0x0001091D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXAt._execute_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXAt._execute_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700098C RID: 2444
			// (get) Token: 0x060026BF RID: 9919 RVA: 0x000AA714 File Offset: 0x000A8914
			// (set) Token: 0x060026C0 RID: 9920 RVA: 0x00012738 File Offset: 0x00010938
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXAt._execute_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXAt._execute_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700098D RID: 2445
			// (get) Token: 0x060026C1 RID: 9921 RVA: 0x000AA744 File Offset: 0x000A8944
			// (set) Token: 0x060026C2 RID: 9922 RVA: 0x00012757 File Offset: 0x00010957
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXAt._execute_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXAt._execute_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700098E RID: 2446
			// (get) Token: 0x060026C3 RID: 9923 RVA: 0x000AA76C File Offset: 0x000A896C
			// (set) Token: 0x060026C4 RID: 9924 RVA: 0x00012772 File Offset: 0x00010972
			public unsafe PlayFXAt __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXAt._execute_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayFXAt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXAt._execute_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700098F RID: 2447
			// (get) Token: 0x060026C5 RID: 9925 RVA: 0x000AA79C File Offset: 0x000A899C
			// (set) Token: 0x060026C6 RID: 9926 RVA: 0x00012791 File Offset: 0x00010991
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXAt._execute_d__7.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXAt._execute_d__7.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001825 RID: 6181
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001826 RID: 6182
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001827 RID: 6183
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001828 RID: 6184
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001829 RID: 6185
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400182A RID: 6186
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400182B RID: 6187
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400182C RID: 6188
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400182D RID: 6189
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400182E RID: 6190
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400182F RID: 6191
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001830 RID: 6192
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001831 RID: 6193
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001832 RID: 6194
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020003A3 RID: 931
		private sealed class MethodInfoStoreGeneric_WithAttribute_Public_PlayFXAt_AttributeDefinition_1_T_T_0<T>
		{
			// Token: 0x04001833 RID: 6195
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayFXAt.NativeMethodInfoPtr_WithAttribute_Public_PlayFXAt_AttributeDefinition_1_T_T_0, Il2CppClassPointerStore<PlayFXAt>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
