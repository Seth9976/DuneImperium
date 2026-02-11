using System;
using dwd.core.match.data;
using dwd.core.ui.match.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001FF RID: 511
	public class WormLeaderSelectionPrompter : MonoBehaviour
	{
		// Token: 0x060016A6 RID: 5798 RVA: 0x0005CD50 File Offset: 0x0005AF50
		// Note: this type is marked as 'beforefieldinit'.
		static WormLeaderSelectionPrompter()
		{
			Il2CppClassPointerStore<WormLeaderSelectionPrompter>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormLeaderSelectionPrompter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLeaderSelectionPrompter>.NativeClassPtr);
			WormLeaderSelectionPrompter.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionPrompter>.NativeClassPtr, "prompt");
			WormLeaderSelectionPrompter.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionPrompter>.NativeClassPtr, "entities");
			WormLeaderSelectionPrompter.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionPrompter>.NativeClassPtr, 100666448);
			WormLeaderSelectionPrompter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionPrompter>.NativeClassPtr, 100666449);
			WormLeaderSelectionPrompter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionPrompter>.NativeClassPtr, 100666450);
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x0005CDE4 File Offset: 0x0005AFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716787, XrefRangeEnd = 716792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionPrompter.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x0005CE24 File Offset: 0x0005B024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716792, XrefRangeEnd = 716821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionPrompter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x0005CE58 File Offset: 0x0005B058
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormLeaderSelectionPrompter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLeaderSelectionPrompter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionPrompter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
		public WormLeaderSelectionPrompter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060016AB RID: 5803 RVA: 0x0005CE94 File Offset: 0x0005B094
		// (set) Token: 0x060016AC RID: 5804 RVA: 0x0000DA01 File Offset: 0x0000BC01
		public unsafe FlavoredDismissablePrompt prompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionPrompter.NativeFieldInfoPtr_prompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlavoredDismissablePrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionPrompter.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060016AD RID: 5805 RVA: 0x0005CEC4 File Offset: 0x0005B0C4
		// (set) Token: 0x060016AE RID: 5806 RVA: 0x0000DA20 File Offset: 0x0000BC20
		public unsafe WormEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionPrompter.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionPrompter.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeFieldInfoPtr_prompt;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003F7 RID: 1015
		[ObfuscatedName("worm.match.components.WormLeaderSelectionPrompter+<Start>d__2")]
		public sealed class _Start_d__2 : global::Il2CppSystem.Object
		{
			// Token: 0x0600295C RID: 10588 RVA: 0x0009560C File Offset: 0x0009380C
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__2()
			{
				Il2CppClassPointerStore<WormLeaderSelectionPrompter._Start_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormLeaderSelectionPrompter>.NativeClassPtr, "<Start>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLeaderSelectionPrompter._Start_d__2>.NativeClassPtr);
				WormLeaderSelectionPrompter._Start_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionPrompter._Start_d__2>.NativeClassPtr, "<>1__state");
				WormLeaderSelectionPrompter._Start_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionPrompter._Start_d__2>.NativeClassPtr, "<>2__current");
				WormLeaderSelectionPrompter._Start_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionPrompter._Start_d__2>.NativeClassPtr, "<>4__this");
				WormLeaderSelectionPrompter._Start_d__2.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectionPrompter._Start_d__2>.NativeClassPtr, "<entitiesProvider>5__2");
				WormLeaderSelectionPrompter._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionPrompter._Start_d__2>.NativeClassPtr, 100666451);
				WormLeaderSelectionPrompter._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionPrompter._Start_d__2>.NativeClassPtr, 100666452);
				WormLeaderSelectionPrompter._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionPrompter._Start_d__2>.NativeClassPtr, 100666453);
				WormLeaderSelectionPrompter._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionPrompter._Start_d__2>.NativeClassPtr, 100666454);
				WormLeaderSelectionPrompter._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionPrompter._Start_d__2>.NativeClassPtr, 100666455);
				WormLeaderSelectionPrompter._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectionPrompter._Start_d__2>.NativeClassPtr, 100666456);
			}

			// Token: 0x0600295D RID: 10589 RVA: 0x00095700 File Offset: 0x00093900
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLeaderSelectionPrompter._Start_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionPrompter._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600295E RID: 10590 RVA: 0x00095748 File Offset: 0x00093948
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionPrompter._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600295F RID: 10591 RVA: 0x0009577C File Offset: 0x0009397C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716775, XrefRangeEnd = 716782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionPrompter._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BA9 RID: 2985
			// (get) Token: 0x06002960 RID: 10592 RVA: 0x000957B8 File Offset: 0x000939B8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionPrompter._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002961 RID: 10593 RVA: 0x000957F8 File Offset: 0x000939F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716782, XrefRangeEnd = 716787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionPrompter._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BAA RID: 2986
			// (get) Token: 0x06002962 RID: 10594 RVA: 0x0009582C File Offset: 0x00093A2C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectionPrompter._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002963 RID: 10595 RVA: 0x00016A39 File Offset: 0x00014C39
			public _Start_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BA5 RID: 2981
			// (get) Token: 0x06002964 RID: 10596 RVA: 0x0009586C File Offset: 0x00093A6C
			// (set) Token: 0x06002965 RID: 10597 RVA: 0x00016A42 File Offset: 0x00014C42
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionPrompter._Start_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionPrompter._Start_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BA6 RID: 2982
			// (get) Token: 0x06002966 RID: 10598 RVA: 0x00095894 File Offset: 0x00093A94
			// (set) Token: 0x06002967 RID: 10599 RVA: 0x00016A5D File Offset: 0x00014C5D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionPrompter._Start_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionPrompter._Start_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BA7 RID: 2983
			// (get) Token: 0x06002968 RID: 10600 RVA: 0x000958C4 File Offset: 0x00093AC4
			// (set) Token: 0x06002969 RID: 10601 RVA: 0x00016A7C File Offset: 0x00014C7C
			public unsafe WormLeaderSelectionPrompter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionPrompter._Start_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormLeaderSelectionPrompter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionPrompter._Start_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BA8 RID: 2984
			// (get) Token: 0x0600296A RID: 10602 RVA: 0x000958F4 File Offset: 0x00093AF4
			// (set) Token: 0x0600296B RID: 10603 RVA: 0x00016A9B File Offset: 0x00014C9B
			public unsafe EntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionPrompter._Start_d__2.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectionPrompter._Start_d__2.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017D8 RID: 6104
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017D9 RID: 6105
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017DA RID: 6106
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017DB RID: 6107
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x040017DC RID: 6108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017DD RID: 6109
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017DE RID: 6110
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017DF RID: 6111
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017E0 RID: 6112
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017E1 RID: 6113
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
