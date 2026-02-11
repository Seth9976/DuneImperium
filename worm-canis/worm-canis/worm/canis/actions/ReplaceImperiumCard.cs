using System;
using Canis;
using Canis.actions;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x02000273 RID: 627
	public class ReplaceImperiumCard : global::Canis.actions.Action
	{
		// Token: 0x06001A77 RID: 6775 RVA: 0x000BFBF0 File Offset: 0x000BDDF0
		// Note: this type is marked as 'beforefieldinit'.
		static ReplaceImperiumCard()
		{
			Il2CppClassPointerStore<ReplaceImperiumCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "ReplaceImperiumCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceImperiumCard>.NativeClassPtr);
			ReplaceImperiumCard.NativeFieldInfoPtr_replaceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceImperiumCard>.NativeClassPtr, "replaceIndex");
			ReplaceImperiumCard.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceImperiumCard>.NativeClassPtr, 100668361);
			ReplaceImperiumCard.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceImperiumCard>.NativeClassPtr, 100668362);
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x000BFC5C File Offset: 0x000BDE5C
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 142727, RefRangeEnd = 142766, XrefRangeStart = 142726, XrefRangeEnd = 142727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReplaceImperiumCard(int indexToReplace, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplaceImperiumCard>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref indexToReplace;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceImperiumCard.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x000BFCB8 File Offset: 0x000BDEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142766, XrefRangeEnd = 142772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReplaceImperiumCard.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x0000B64F File Offset: 0x0000984F
		public ReplaceImperiumCard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001A7B RID: 6779 RVA: 0x000BFD04 File Offset: 0x000BDF04
		// (set) Token: 0x06001A7C RID: 6780 RVA: 0x0000B658 File Offset: 0x00009858
		public unsafe int replaceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceImperiumCard.NativeFieldInfoPtr_replaceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceImperiumCard.NativeFieldInfoPtr_replaceIndex)) = value;
			}
		}

		// Token: 0x04001054 RID: 4180
		private static readonly IntPtr NativeFieldInfoPtr_replaceIndex;

		// Token: 0x04001055 RID: 4181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0;

		// Token: 0x04001056 RID: 4182
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x020006B4 RID: 1716
		[ObfuscatedName("worm.canis.actions.ReplaceImperiumCard+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005A9C RID: 23196 RVA: 0x001C8814 File Offset: 0x001C6A14
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ReplaceImperiumCard.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceImperiumCard>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceImperiumCard.__c>.NativeClassPtr);
				ReplaceImperiumCard.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceImperiumCard.__c>.NativeClassPtr, "<>9");
				ReplaceImperiumCard.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceImperiumCard.__c>.NativeClassPtr, "<>9__2_0");
				ReplaceImperiumCard.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceImperiumCard.__c>.NativeClassPtr, 100668364);
				ReplaceImperiumCard.__c.NativeMethodInfoPtr__execute_b__2_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceImperiumCard.__c>.NativeClassPtr, 100668365);
			}

			// Token: 0x06005A9D RID: 23197 RVA: 0x001C8890 File Offset: 0x001C6A90
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplaceImperiumCard.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceImperiumCard.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A9E RID: 23198 RVA: 0x001C88CC File Offset: 0x001C6ACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142548, XrefRangeEnd = 142555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__2_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceImperiumCard.__c.NativeMethodInfoPtr__execute_b__2_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005A9F RID: 23199 RVA: 0x000216F1 File Offset: 0x0001F8F1
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001766 RID: 5990
			// (get) Token: 0x06005AA0 RID: 23200 RVA: 0x001C891C File Offset: 0x001C6B1C
			// (set) Token: 0x06005AA1 RID: 23201 RVA: 0x000216FA File Offset: 0x0001F8FA
			public unsafe static ReplaceImperiumCard.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReplaceImperiumCard.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReplaceImperiumCard.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReplaceImperiumCard.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001767 RID: 5991
			// (get) Token: 0x06005AA2 RID: 23202 RVA: 0x001C8944 File Offset: 0x001C6B44
			// (set) Token: 0x06005AA3 RID: 23203 RVA: 0x0002170C File Offset: 0x0001F90C
			public unsafe static Func<Entity, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReplaceImperiumCard.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReplaceImperiumCard.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003AFD RID: 15101
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003AFE RID: 15102
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04003AFF RID: 15103
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003B00 RID: 15104
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__2_0_Internal_Boolean_Entity_0;
		}

		// Token: 0x020006B5 RID: 1717
		[ObfuscatedName("worm.canis.actions.ReplaceImperiumCard+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06005AA4 RID: 23204 RVA: 0x001C896C File Offset: 0x001C6B6C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<ReplaceImperiumCard._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceImperiumCard>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceImperiumCard._execute_d__2>.NativeClassPtr);
				ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceImperiumCard._execute_d__2>.NativeClassPtr, "<>1__state");
				ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceImperiumCard._execute_d__2>.NativeClassPtr, "<>2__current");
				ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceImperiumCard._execute_d__2>.NativeClassPtr, "<>l__initialThreadId");
				ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceImperiumCard._execute_d__2>.NativeClassPtr, "<>4__this");
				ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr__wm_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceImperiumCard._execute_d__2>.NativeClassPtr, "<wm>5__2");
				ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr__nextImperiumCard_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceImperiumCard._execute_d__2>.NativeClassPtr, "<nextImperiumCard>5__3");
				ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceImperiumCard._execute_d__2>.NativeClassPtr, "<>7__wrap3");
				ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr__trashedCards_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceImperiumCard._execute_d__2>.NativeClassPtr, "<trashedCards>5__5");
				ReplaceImperiumCard._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceImperiumCard._execute_d__2>.NativeClassPtr, 100668366);
				ReplaceImperiumCard._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceImperiumCard._execute_d__2>.NativeClassPtr, 100668367);
				ReplaceImperiumCard._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceImperiumCard._execute_d__2>.NativeClassPtr, 100668368);
				ReplaceImperiumCard._execute_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceImperiumCard._execute_d__2>.NativeClassPtr, 100668369);
				ReplaceImperiumCard._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceImperiumCard._execute_d__2>.NativeClassPtr, 100668370);
				ReplaceImperiumCard._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceImperiumCard._execute_d__2>.NativeClassPtr, 100668371);
				ReplaceImperiumCard._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceImperiumCard._execute_d__2>.NativeClassPtr, 100668372);
				ReplaceImperiumCard._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceImperiumCard._execute_d__2>.NativeClassPtr, 100668373);
				ReplaceImperiumCard._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceImperiumCard._execute_d__2>.NativeClassPtr, 100668374);
			}

			// Token: 0x06005AA5 RID: 23205 RVA: 0x001C8AEC File Offset: 0x001C6CEC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplaceImperiumCard._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceImperiumCard._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005AA6 RID: 23206 RVA: 0x001C8B34 File Offset: 0x001C6D34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142555, XrefRangeEnd = 142560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceImperiumCard._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005AA7 RID: 23207 RVA: 0x001C8B68 File Offset: 0x001C6D68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142560, XrefRangeEnd = 142716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceImperiumCard._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005AA8 RID: 23208 RVA: 0x001C8BA4 File Offset: 0x001C6DA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142716, XrefRangeEnd = 142719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceImperiumCard._execute_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001770 RID: 6000
			// (get) Token: 0x06005AA9 RID: 23209 RVA: 0x001C8BD8 File Offset: 0x001C6DD8
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceImperiumCard._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005AAA RID: 23210 RVA: 0x001C8C18 File Offset: 0x001C6E18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142719, XrefRangeEnd = 142724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceImperiumCard._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001771 RID: 6001
			// (get) Token: 0x06005AAB RID: 23211 RVA: 0x001C8C4C File Offset: 0x001C6E4C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceImperiumCard._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005AAC RID: 23212 RVA: 0x001C8C8C File Offset: 0x001C6E8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142724, XrefRangeEnd = 142726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceImperiumCard._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005AAD RID: 23213 RVA: 0x001C8CCC File Offset: 0x001C6ECC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceImperiumCard._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005AAE RID: 23214 RVA: 0x0002171E File Offset: 0x0001F91E
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001768 RID: 5992
			// (get) Token: 0x06005AAF RID: 23215 RVA: 0x001C8D0C File Offset: 0x001C6F0C
			// (set) Token: 0x06005AB0 RID: 23216 RVA: 0x00021727 File Offset: 0x0001F927
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001769 RID: 5993
			// (get) Token: 0x06005AB1 RID: 23217 RVA: 0x001C8D34 File Offset: 0x001C6F34
			// (set) Token: 0x06005AB2 RID: 23218 RVA: 0x00021742 File Offset: 0x0001F942
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700176A RID: 5994
			// (get) Token: 0x06005AB3 RID: 23219 RVA: 0x001C8D64 File Offset: 0x001C6F64
			// (set) Token: 0x06005AB4 RID: 23220 RVA: 0x00021761 File Offset: 0x0001F961
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700176B RID: 5995
			// (get) Token: 0x06005AB5 RID: 23221 RVA: 0x001C8D8C File Offset: 0x001C6F8C
			// (set) Token: 0x06005AB6 RID: 23222 RVA: 0x0002177C File Offset: 0x0001F97C
			public unsafe ReplaceImperiumCard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReplaceImperiumCard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700176C RID: 5996
			// (get) Token: 0x06005AB7 RID: 23223 RVA: 0x001C8DBC File Offset: 0x001C6FBC
			// (set) Token: 0x06005AB8 RID: 23224 RVA: 0x0002179B File Offset: 0x0001F99B
			public unsafe WormMatch _wm_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr__wm_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr__wm_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700176D RID: 5997
			// (get) Token: 0x06005AB9 RID: 23225 RVA: 0x001C8DEC File Offset: 0x001C6FEC
			// (set) Token: 0x06005ABA RID: 23226 RVA: 0x000217BA File Offset: 0x0001F9BA
			public unsafe WormPlayable _nextImperiumCard_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr__nextImperiumCard_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr__nextImperiumCard_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700176E RID: 5998
			// (get) Token: 0x06005ABB RID: 23227 RVA: 0x001C8E1C File Offset: 0x001C701C
			// (set) Token: 0x06005ABC RID: 23228 RVA: 0x000217D9 File Offset: 0x0001F9D9
			public unsafe IEnumerator<PlayerEntity> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700176F RID: 5999
			// (get) Token: 0x06005ABD RID: 23229 RVA: 0x001C8E4C File Offset: 0x001C704C
			// (set) Token: 0x06005ABE RID: 23230 RVA: 0x000217F8 File Offset: 0x0001F9F8
			public unsafe List<Entity> _trashedCards_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr__trashedCards_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceImperiumCard._execute_d__2.NativeFieldInfoPtr__trashedCards_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B01 RID: 15105
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003B02 RID: 15106
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003B03 RID: 15107
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003B04 RID: 15108
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003B05 RID: 15109
			private static readonly IntPtr NativeFieldInfoPtr__wm_5__2;

			// Token: 0x04003B06 RID: 15110
			private static readonly IntPtr NativeFieldInfoPtr__nextImperiumCard_5__3;

			// Token: 0x04003B07 RID: 15111
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04003B08 RID: 15112
			private static readonly IntPtr NativeFieldInfoPtr__trashedCards_5__5;

			// Token: 0x04003B09 RID: 15113
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003B0A RID: 15114
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B0B RID: 15115
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003B0C RID: 15116
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003B0D RID: 15117
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003B0E RID: 15118
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B0F RID: 15119
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003B10 RID: 15120
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003B11 RID: 15121
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
