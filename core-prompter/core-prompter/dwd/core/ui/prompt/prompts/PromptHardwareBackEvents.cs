using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x02000014 RID: 20
	public class PromptHardwareBackEvents : MonoBehaviour
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x00006928 File Offset: 0x00004B28
		// Note: this type is marked as 'beforefieldinit'.
		static PromptHardwareBackEvents()
		{
			Il2CppClassPointerStore<PromptHardwareBackEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "PromptHardwareBackEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PromptHardwareBackEvents>.NativeClassPtr);
			PromptHardwareBackEvents.NativeFieldInfoPtr_maxOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptHardwareBackEvents>.NativeClassPtr, "maxOrder");
			PromptHardwareBackEvents.NativeFieldInfoPtr_onHardwareBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptHardwareBackEvents>.NativeClassPtr, "onHardwareBack");
			PromptHardwareBackEvents.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptHardwareBackEvents>.NativeClassPtr, 100663370);
			PromptHardwareBackEvents.NativeMethodInfoPtr_waitForBack_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptHardwareBackEvents>.NativeClassPtr, 100663371);
			PromptHardwareBackEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptHardwareBackEvents>.NativeClassPtr, 100663372);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000069BC File Offset: 0x00004BBC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptHardwareBackEvents.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000069F0 File Offset: 0x00004BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213482, XrefRangeEnd = 1213487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator waitForBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptHardwareBackEvents.NativeMethodInfoPtr_waitForBack_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00006A30 File Offset: 0x00004C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213487, XrefRangeEnd = 1213493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PromptHardwareBackEvents()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PromptHardwareBackEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptHardwareBackEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002834 File Offset: 0x00000A34
		public PromptHardwareBackEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00006A6C File Offset: 0x00004C6C
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000283D File Offset: 0x00000A3D
		public unsafe static int maxOrder
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PromptHardwareBackEvents.NativeFieldInfoPtr_maxOrder, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PromptHardwareBackEvents.NativeFieldInfoPtr_maxOrder, (void*)(&value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00006A88 File Offset: 0x00004C88
		// (set) Token: 0x060000FA RID: 250 RVA: 0x0000284B File Offset: 0x00000A4B
		public unsafe UnityEvent onHardwareBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptHardwareBackEvents.NativeFieldInfoPtr_onHardwareBack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptHardwareBackEvents.NativeFieldInfoPtr_onHardwareBack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_maxOrder;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr_onHardwareBack;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_waitForBack_Private_IEnumerator_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200004B RID: 75
		[ObfuscatedName("dwd.core.ui.prompt.prompts.PromptHardwareBackEvents+<waitForBack>d__3")]
		public sealed class _waitForBack_d__3 : global::Il2CppSystem.Object
		{
			// Token: 0x060002E7 RID: 743 RVA: 0x0000D134 File Offset: 0x0000B334
			// Note: this type is marked as 'beforefieldinit'.
			static _waitForBack_d__3()
			{
				Il2CppClassPointerStore<PromptHardwareBackEvents._waitForBack_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PromptHardwareBackEvents>.NativeClassPtr, "<waitForBack>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PromptHardwareBackEvents._waitForBack_d__3>.NativeClassPtr);
				PromptHardwareBackEvents._waitForBack_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptHardwareBackEvents._waitForBack_d__3>.NativeClassPtr, "<>1__state");
				PromptHardwareBackEvents._waitForBack_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptHardwareBackEvents._waitForBack_d__3>.NativeClassPtr, "<>2__current");
				PromptHardwareBackEvents._waitForBack_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptHardwareBackEvents._waitForBack_d__3>.NativeClassPtr, "<>4__this");
				PromptHardwareBackEvents._waitForBack_d__3.NativeFieldInfoPtr__canvasOrder_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptHardwareBackEvents._waitForBack_d__3>.NativeClassPtr, "<canvasOrder>5__2");
				PromptHardwareBackEvents._waitForBack_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptHardwareBackEvents._waitForBack_d__3>.NativeClassPtr, 100663374);
				PromptHardwareBackEvents._waitForBack_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptHardwareBackEvents._waitForBack_d__3>.NativeClassPtr, 100663375);
				PromptHardwareBackEvents._waitForBack_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptHardwareBackEvents._waitForBack_d__3>.NativeClassPtr, 100663376);
				PromptHardwareBackEvents._waitForBack_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptHardwareBackEvents._waitForBack_d__3>.NativeClassPtr, 100663377);
				PromptHardwareBackEvents._waitForBack_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptHardwareBackEvents._waitForBack_d__3>.NativeClassPtr, 100663378);
				PromptHardwareBackEvents._waitForBack_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptHardwareBackEvents._waitForBack_d__3>.NativeClassPtr, 100663379);
			}

			// Token: 0x060002E8 RID: 744 RVA: 0x0000D228 File Offset: 0x0000B428
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _waitForBack_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PromptHardwareBackEvents._waitForBack_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptHardwareBackEvents._waitForBack_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002E9 RID: 745 RVA: 0x0000D270 File Offset: 0x0000B470
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptHardwareBackEvents._waitForBack_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002EA RID: 746 RVA: 0x0000D2A4 File Offset: 0x0000B4A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213470, XrefRangeEnd = 1213477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptHardwareBackEvents._waitForBack_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x060002EB RID: 747 RVA: 0x0000D2E0 File Offset: 0x0000B4E0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptHardwareBackEvents._waitForBack_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002EC RID: 748 RVA: 0x0000D320 File Offset: 0x0000B520
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213477, XrefRangeEnd = 1213482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptHardwareBackEvents._waitForBack_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x060002ED RID: 749 RVA: 0x0000D354 File Offset: 0x0000B554
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptHardwareBackEvents._waitForBack_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002EE RID: 750 RVA: 0x00003829 File Offset: 0x00001A29
			public _waitForBack_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x060002EF RID: 751 RVA: 0x0000D394 File Offset: 0x0000B594
			// (set) Token: 0x060002F0 RID: 752 RVA: 0x00003832 File Offset: 0x00001A32
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptHardwareBackEvents._waitForBack_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptHardwareBackEvents._waitForBack_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x060002F1 RID: 753 RVA: 0x0000D3BC File Offset: 0x0000B5BC
			// (set) Token: 0x060002F2 RID: 754 RVA: 0x0000384D File Offset: 0x00001A4D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptHardwareBackEvents._waitForBack_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptHardwareBackEvents._waitForBack_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x060002F3 RID: 755 RVA: 0x0000D3EC File Offset: 0x0000B5EC
			// (set) Token: 0x060002F4 RID: 756 RVA: 0x0000386C File Offset: 0x00001A6C
			public unsafe PromptHardwareBackEvents __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptHardwareBackEvents._waitForBack_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PromptHardwareBackEvents>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptHardwareBackEvents._waitForBack_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000D41C File Offset: 0x0000B61C
			// (set) Token: 0x060002F6 RID: 758 RVA: 0x0000388B File Offset: 0x00001A8B
			public unsafe int _canvasOrder_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptHardwareBackEvents._waitForBack_d__3.NativeFieldInfoPtr__canvasOrder_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptHardwareBackEvents._waitForBack_d__3.NativeFieldInfoPtr__canvasOrder_5__2)) = value;
				}
			}

			// Token: 0x040001A1 RID: 417
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001A2 RID: 418
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040001A3 RID: 419
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040001A4 RID: 420
			private static readonly IntPtr NativeFieldInfoPtr__canvasOrder_5__2;

			// Token: 0x040001A5 RID: 421
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040001A6 RID: 422
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001A7 RID: 423
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040001A8 RID: 424
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040001A9 RID: 425
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001AA RID: 426
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
