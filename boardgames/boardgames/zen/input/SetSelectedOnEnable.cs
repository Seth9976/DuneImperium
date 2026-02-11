using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace zen.input
{
	// Token: 0x02000048 RID: 72
	public class SetSelectedOnEnable : MonoBehaviour
	{
		// Token: 0x060002D8 RID: 728 RVA: 0x0001A4B8 File Offset: 0x000186B8
		// Note: this type is marked as 'beforefieldinit'.
		static SetSelectedOnEnable()
		{
			Il2CppClassPointerStore<SetSelectedOnEnable>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.input", "SetSelectedOnEnable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetSelectedOnEnable>.NativeClassPtr);
			SetSelectedOnEnable.NativeFieldInfoPtr_selectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSelectedOnEnable>.NativeClassPtr, "selectable");
			SetSelectedOnEnable.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSelectedOnEnable>.NativeClassPtr, 100663798);
			SetSelectedOnEnable.NativeMethodInfoPtr_SetSelectedGameObject_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSelectedOnEnable>.NativeClassPtr, 100663799);
			SetSelectedOnEnable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSelectedOnEnable>.NativeClassPtr, 100663800);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0001A538 File Offset: 0x00018738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985447, XrefRangeEnd = 985461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSelectedOnEnable.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0001A56C File Offset: 0x0001876C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985461, XrefRangeEnd = 985466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SetSelectedGameObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSelectedOnEnable.NativeMethodInfoPtr_SetSelectedGameObject_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0001A5AC File Offset: 0x000187AC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetSelectedOnEnable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetSelectedOnEnable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSelectedOnEnable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000338B File Offset: 0x0000158B
		public SetSelectedOnEnable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002DD RID: 733 RVA: 0x0001A5E8 File Offset: 0x000187E8
		// (set) Token: 0x060002DE RID: 734 RVA: 0x00003394 File Offset: 0x00001594
		public unsafe Selectable selectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSelectedOnEnable.NativeFieldInfoPtr_selectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSelectedOnEnable.NativeFieldInfoPtr_selectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeFieldInfoPtr_selectable;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedGameObject_Private_IEnumerator_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001B6 RID: 438
		[ObfuscatedName("zen.input.SetSelectedOnEnable+<SetSelectedGameObject>d__2")]
		public sealed class _SetSelectedGameObject_d__2 : global::Il2CppSystem.Object
		{
			// Token: 0x06001519 RID: 5401 RVA: 0x00052130 File Offset: 0x00050330
			// Note: this type is marked as 'beforefieldinit'.
			static _SetSelectedGameObject_d__2()
			{
				Il2CppClassPointerStore<SetSelectedOnEnable._SetSelectedGameObject_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetSelectedOnEnable>.NativeClassPtr, "<SetSelectedGameObject>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetSelectedOnEnable._SetSelectedGameObject_d__2>.NativeClassPtr);
				SetSelectedOnEnable._SetSelectedGameObject_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSelectedOnEnable._SetSelectedGameObject_d__2>.NativeClassPtr, "<>1__state");
				SetSelectedOnEnable._SetSelectedGameObject_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSelectedOnEnable._SetSelectedGameObject_d__2>.NativeClassPtr, "<>2__current");
				SetSelectedOnEnable._SetSelectedGameObject_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSelectedOnEnable._SetSelectedGameObject_d__2>.NativeClassPtr, "<>4__this");
				SetSelectedOnEnable._SetSelectedGameObject_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSelectedOnEnable._SetSelectedGameObject_d__2>.NativeClassPtr, 100663801);
				SetSelectedOnEnable._SetSelectedGameObject_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSelectedOnEnable._SetSelectedGameObject_d__2>.NativeClassPtr, 100663802);
				SetSelectedOnEnable._SetSelectedGameObject_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSelectedOnEnable._SetSelectedGameObject_d__2>.NativeClassPtr, 100663803);
				SetSelectedOnEnable._SetSelectedGameObject_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSelectedOnEnable._SetSelectedGameObject_d__2>.NativeClassPtr, 100663804);
				SetSelectedOnEnable._SetSelectedGameObject_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSelectedOnEnable._SetSelectedGameObject_d__2>.NativeClassPtr, 100663805);
				SetSelectedOnEnable._SetSelectedGameObject_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSelectedOnEnable._SetSelectedGameObject_d__2>.NativeClassPtr, 100663806);
			}

			// Token: 0x0600151A RID: 5402 RVA: 0x00052210 File Offset: 0x00050410
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SetSelectedGameObject_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetSelectedOnEnable._SetSelectedGameObject_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSelectedOnEnable._SetSelectedGameObject_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600151B RID: 5403 RVA: 0x00052258 File Offset: 0x00050458
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSelectedOnEnable._SetSelectedGameObject_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600151C RID: 5404 RVA: 0x0005228C File Offset: 0x0005048C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985440, XrefRangeEnd = 985442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSelectedOnEnable._SetSelectedGameObject_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000606 RID: 1542
			// (get) Token: 0x0600151D RID: 5405 RVA: 0x000522C8 File Offset: 0x000504C8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSelectedOnEnable._SetSelectedGameObject_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600151E RID: 5406 RVA: 0x00052308 File Offset: 0x00050508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985442, XrefRangeEnd = 985447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSelectedOnEnable._SetSelectedGameObject_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000607 RID: 1543
			// (get) Token: 0x0600151F RID: 5407 RVA: 0x0005233C File Offset: 0x0005053C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSelectedOnEnable._SetSelectedGameObject_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001520 RID: 5408 RVA: 0x0000BE12 File Offset: 0x0000A012
			public _SetSelectedGameObject_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000603 RID: 1539
			// (get) Token: 0x06001521 RID: 5409 RVA: 0x0005237C File Offset: 0x0005057C
			// (set) Token: 0x06001522 RID: 5410 RVA: 0x0000BE1B File Offset: 0x0000A01B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSelectedOnEnable._SetSelectedGameObject_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSelectedOnEnable._SetSelectedGameObject_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000604 RID: 1540
			// (get) Token: 0x06001523 RID: 5411 RVA: 0x000523A4 File Offset: 0x000505A4
			// (set) Token: 0x06001524 RID: 5412 RVA: 0x0000BE36 File Offset: 0x0000A036
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSelectedOnEnable._SetSelectedGameObject_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSelectedOnEnable._SetSelectedGameObject_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000605 RID: 1541
			// (get) Token: 0x06001525 RID: 5413 RVA: 0x000523D4 File Offset: 0x000505D4
			// (set) Token: 0x06001526 RID: 5414 RVA: 0x0000BE55 File Offset: 0x0000A055
			public unsafe SetSelectedOnEnable __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSelectedOnEnable._SetSelectedGameObject_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetSelectedOnEnable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSelectedOnEnable._SetSelectedGameObject_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000CC8 RID: 3272
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000CC9 RID: 3273
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000CCA RID: 3274
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000CCB RID: 3275
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000CCC RID: 3276
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000CCD RID: 3277
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000CCE RID: 3278
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000CCF RID: 3279
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000CD0 RID: 3280
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
