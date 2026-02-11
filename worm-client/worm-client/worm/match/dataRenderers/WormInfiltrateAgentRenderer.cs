using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine;

namespace worm.match.dataRenderers
{
	// Token: 0x0200013F RID: 319
	public class WormInfiltrateAgentRenderer : Observer
	{
		// Token: 0x06000E59 RID: 3673 RVA: 0x000435BC File Offset: 0x000417BC
		// Note: this type is marked as 'beforefieldinit'.
		static WormInfiltrateAgentRenderer()
		{
			Il2CppClassPointerStore<WormInfiltrateAgentRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormInfiltrateAgentRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormInfiltrateAgentRenderer>.NativeClassPtr);
			WormInfiltrateAgentRenderer.NativeFieldInfoPtr_anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormInfiltrateAgentRenderer>.NativeClassPtr, "anchor");
			WormInfiltrateAgentRenderer.NativeFieldInfoPtr_secondAgentMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormInfiltrateAgentRenderer>.NativeClassPtr, "secondAgentMaterial");
			WormInfiltrateAgentRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormInfiltrateAgentRenderer>.NativeClassPtr, 100665238);
			WormInfiltrateAgentRenderer.NativeMethodInfoPtr_applyMaterial_Private_IEnumerator_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormInfiltrateAgentRenderer>.NativeClassPtr, 100665239);
			WormInfiltrateAgentRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormInfiltrateAgentRenderer>.NativeClassPtr, 100665240);
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00043650 File Offset: 0x00041850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706521, XrefRangeEnd = 706533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormInfiltrateAgentRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x0004368C File Offset: 0x0004188C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706533, XrefRangeEnd = 706539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator applyMaterial(Transform applyTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(applyTo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormInfiltrateAgentRenderer.NativeMethodInfoPtr_applyMaterial_Private_IEnumerator_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x000436DC File Offset: 0x000418DC
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormInfiltrateAgentRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormInfiltrateAgentRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormInfiltrateAgentRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x000098D8 File Offset: 0x00007AD8
		public WormInfiltrateAgentRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00043718 File Offset: 0x00041918
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x000098E1 File Offset: 0x00007AE1
		public unsafe GameObject anchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormInfiltrateAgentRenderer.NativeFieldInfoPtr_anchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormInfiltrateAgentRenderer.NativeFieldInfoPtr_anchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x00043748 File Offset: 0x00041948
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x00009900 File Offset: 0x00007B00
		public unsafe Material secondAgentMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormInfiltrateAgentRenderer.NativeFieldInfoPtr_secondAgentMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormInfiltrateAgentRenderer.NativeFieldInfoPtr_secondAgentMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeFieldInfoPtr_anchor;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeFieldInfoPtr_secondAgentMaterial;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeMethodInfoPtr_applyMaterial_Private_IEnumerator_Transform_0;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000390 RID: 912
		[ObfuscatedName("worm.match.dataRenderers.WormInfiltrateAgentRenderer+<applyMaterial>d__3")]
		public sealed class _applyMaterial_d__3 : global::Il2CppSystem.Object
		{
			// Token: 0x060024A3 RID: 9379 RVA: 0x00086E94 File Offset: 0x00085094
			// Note: this type is marked as 'beforefieldinit'.
			static _applyMaterial_d__3()
			{
				Il2CppClassPointerStore<WormInfiltrateAgentRenderer._applyMaterial_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormInfiltrateAgentRenderer>.NativeClassPtr, "<applyMaterial>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormInfiltrateAgentRenderer._applyMaterial_d__3>.NativeClassPtr);
				WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormInfiltrateAgentRenderer._applyMaterial_d__3>.NativeClassPtr, "<>1__state");
				WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormInfiltrateAgentRenderer._applyMaterial_d__3>.NativeClassPtr, "<>2__current");
				WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeFieldInfoPtr_applyTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormInfiltrateAgentRenderer._applyMaterial_d__3>.NativeClassPtr, "applyTo");
				WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormInfiltrateAgentRenderer._applyMaterial_d__3>.NativeClassPtr, "<>4__this");
				WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeFieldInfoPtr__meshRenderer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormInfiltrateAgentRenderer._applyMaterial_d__3>.NativeClassPtr, "<meshRenderer>5__2");
				WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormInfiltrateAgentRenderer._applyMaterial_d__3>.NativeClassPtr, 100665241);
				WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormInfiltrateAgentRenderer._applyMaterial_d__3>.NativeClassPtr, 100665242);
				WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormInfiltrateAgentRenderer._applyMaterial_d__3>.NativeClassPtr, 100665243);
				WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormInfiltrateAgentRenderer._applyMaterial_d__3>.NativeClassPtr, 100665244);
				WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormInfiltrateAgentRenderer._applyMaterial_d__3>.NativeClassPtr, 100665245);
				WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormInfiltrateAgentRenderer._applyMaterial_d__3>.NativeClassPtr, 100665246);
			}

			// Token: 0x060024A4 RID: 9380 RVA: 0x00086F9C File Offset: 0x0008519C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _applyMaterial_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormInfiltrateAgentRenderer._applyMaterial_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060024A5 RID: 9381 RVA: 0x00086FE4 File Offset: 0x000851E4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024A6 RID: 9382 RVA: 0x00087018 File Offset: 0x00085218
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706506, XrefRangeEnd = 706516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A2D RID: 2605
			// (get) Token: 0x060024A7 RID: 9383 RVA: 0x00087054 File Offset: 0x00085254
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024A8 RID: 9384 RVA: 0x00087094 File Offset: 0x00085294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706516, XrefRangeEnd = 706521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A2E RID: 2606
			// (get) Token: 0x060024A9 RID: 9385 RVA: 0x000870C8 File Offset: 0x000852C8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024AA RID: 9386 RVA: 0x000146FE File Offset: 0x000128FE
			public _applyMaterial_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A28 RID: 2600
			// (get) Token: 0x060024AB RID: 9387 RVA: 0x00087108 File Offset: 0x00085308
			// (set) Token: 0x060024AC RID: 9388 RVA: 0x00014707 File Offset: 0x00012907
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A29 RID: 2601
			// (get) Token: 0x060024AD RID: 9389 RVA: 0x00087130 File Offset: 0x00085330
			// (set) Token: 0x060024AE RID: 9390 RVA: 0x00014722 File Offset: 0x00012922
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A2A RID: 2602
			// (get) Token: 0x060024AF RID: 9391 RVA: 0x00087160 File Offset: 0x00085360
			// (set) Token: 0x060024B0 RID: 9392 RVA: 0x00014741 File Offset: 0x00012941
			public unsafe Transform applyTo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeFieldInfoPtr_applyTo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeFieldInfoPtr_applyTo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A2B RID: 2603
			// (get) Token: 0x060024B1 RID: 9393 RVA: 0x00087190 File Offset: 0x00085390
			// (set) Token: 0x060024B2 RID: 9394 RVA: 0x00014760 File Offset: 0x00012960
			public unsafe WormInfiltrateAgentRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormInfiltrateAgentRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A2C RID: 2604
			// (get) Token: 0x060024B3 RID: 9395 RVA: 0x000871C0 File Offset: 0x000853C0
			// (set) Token: 0x060024B4 RID: 9396 RVA: 0x0001477F File Offset: 0x0001297F
			public unsafe MeshRenderer _meshRenderer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeFieldInfoPtr__meshRenderer_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormInfiltrateAgentRenderer._applyMaterial_d__3.NativeFieldInfoPtr__meshRenderer_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001509 RID: 5385
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400150A RID: 5386
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400150B RID: 5387
			private static readonly IntPtr NativeFieldInfoPtr_applyTo;

			// Token: 0x0400150C RID: 5388
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400150D RID: 5389
			private static readonly IntPtr NativeFieldInfoPtr__meshRenderer_5__2;

			// Token: 0x0400150E RID: 5390
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400150F RID: 5391
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001510 RID: 5392
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001511 RID: 5393
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001512 RID: 5394
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001513 RID: 5395
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
