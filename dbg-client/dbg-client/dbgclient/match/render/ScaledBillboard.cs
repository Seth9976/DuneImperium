using System;
using boardgames.match.render;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dbgclient.match.render
{
	// Token: 0x020000A9 RID: 169
	public class ScaledBillboard : MonoBehaviour
	{
		// Token: 0x060006AA RID: 1706 RVA: 0x00032AE0 File Offset: 0x00030CE0
		// Note: this type is marked as 'beforefieldinit'.
		static ScaledBillboard()
		{
			Il2CppClassPointerStore<ScaledBillboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.match.render", "ScaledBillboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScaledBillboard>.NativeClassPtr);
			ScaledBillboard.NativeFieldInfoPtr_doScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaledBillboard>.NativeClassPtr, "doScale");
			ScaledBillboard.NativeFieldInfoPtr_maxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaledBillboard>.NativeClassPtr, "maxScale");
			ScaledBillboard.NativeFieldInfoPtr_strategicViewEnableHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaledBillboard>.NativeClassPtr, "strategicViewEnableHeight");
			ScaledBillboard.NativeFieldInfoPtr_strategicView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaledBillboard>.NativeClassPtr, "strategicView");
			ScaledBillboard.NativeFieldInfoPtr_camTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaledBillboard>.NativeClassPtr, "camTransform");
			ScaledBillboard.NativeFieldInfoPtr_initialScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaledBillboard>.NativeClassPtr, "initialScale");
			ScaledBillboard.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaledBillboard>.NativeClassPtr, 100664348);
			ScaledBillboard.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaledBillboard>.NativeClassPtr, 100664349);
			ScaledBillboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaledBillboard>.NativeClassPtr, 100664350);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00032BC4 File Offset: 0x00030DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503719, XrefRangeEnd = 503724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaledBillboard.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00032C04 File Offset: 0x00030E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503724, XrefRangeEnd = 503744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaledBillboard.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00032C38 File Offset: 0x00030E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503744, XrefRangeEnd = 503745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScaledBillboard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScaledBillboard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaledBillboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00005063 File Offset: 0x00003263
		public ScaledBillboard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x00032C74 File Offset: 0x00030E74
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x0000506C File Offset: 0x0000326C
		public unsafe bool doScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaledBillboard.NativeFieldInfoPtr_doScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaledBillboard.NativeFieldInfoPtr_doScale)) = value;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00032C9C File Offset: 0x00030E9C
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x00005087 File Offset: 0x00003287
		public unsafe float maxScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaledBillboard.NativeFieldInfoPtr_maxScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaledBillboard.NativeFieldInfoPtr_maxScale)) = value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x00032CC4 File Offset: 0x00030EC4
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x000050A2 File Offset: 0x000032A2
		public unsafe float strategicViewEnableHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaledBillboard.NativeFieldInfoPtr_strategicViewEnableHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaledBillboard.NativeFieldInfoPtr_strategicViewEnableHeight)) = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x00032CEC File Offset: 0x00030EEC
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x000050BD File Offset: 0x000032BD
		public unsafe GameObject strategicView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaledBillboard.NativeFieldInfoPtr_strategicView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaledBillboard.NativeFieldInfoPtr_strategicView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x00032D1C File Offset: 0x00030F1C
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x000050DC File Offset: 0x000032DC
		public unsafe Transform camTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaledBillboard.NativeFieldInfoPtr_camTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaledBillboard.NativeFieldInfoPtr_camTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x00032D4C File Offset: 0x00030F4C
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x000050FB File Offset: 0x000032FB
		public unsafe float initialScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaledBillboard.NativeFieldInfoPtr_initialScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaledBillboard.NativeFieldInfoPtr_initialScale)) = value;
			}
		}

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeFieldInfoPtr_doScale;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeFieldInfoPtr_maxScale;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeFieldInfoPtr_strategicViewEnableHeight;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeFieldInfoPtr_strategicView;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeFieldInfoPtr_camTransform;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeFieldInfoPtr_initialScale;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000319 RID: 793
		[ObfuscatedName("dbgclient.match.render.ScaledBillboard+<Start>d__6")]
		public sealed class _Start_d__6 : global::Il2CppSystem.Object
		{
			// Token: 0x06002576 RID: 9590 RVA: 0x0009888C File Offset: 0x00096A8C
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__6()
			{
				Il2CppClassPointerStore<ScaledBillboard._Start_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScaledBillboard>.NativeClassPtr, "<Start>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScaledBillboard._Start_d__6>.NativeClassPtr);
				ScaledBillboard._Start_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaledBillboard._Start_d__6>.NativeClassPtr, "<>1__state");
				ScaledBillboard._Start_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaledBillboard._Start_d__6>.NativeClassPtr, "<>2__current");
				ScaledBillboard._Start_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaledBillboard._Start_d__6>.NativeClassPtr, "<>4__this");
				ScaledBillboard._Start_d__6.NativeFieldInfoPtr__grip_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaledBillboard._Start_d__6>.NativeClassPtr, "<grip>5__2");
				ScaledBillboard._Start_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaledBillboard._Start_d__6>.NativeClassPtr, 100664351);
				ScaledBillboard._Start_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaledBillboard._Start_d__6>.NativeClassPtr, 100664352);
				ScaledBillboard._Start_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaledBillboard._Start_d__6>.NativeClassPtr, 100664353);
				ScaledBillboard._Start_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaledBillboard._Start_d__6>.NativeClassPtr, 100664354);
				ScaledBillboard._Start_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaledBillboard._Start_d__6>.NativeClassPtr, 100664355);
				ScaledBillboard._Start_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaledBillboard._Start_d__6>.NativeClassPtr, 100664356);
			}

			// Token: 0x06002577 RID: 9591 RVA: 0x00098980 File Offset: 0x00096B80
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScaledBillboard._Start_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaledBillboard._Start_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002578 RID: 9592 RVA: 0x000989C8 File Offset: 0x00096BC8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaledBillboard._Start_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002579 RID: 9593 RVA: 0x000989FC File Offset: 0x00096BFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503708, XrefRangeEnd = 503714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaledBillboard._Start_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A53 RID: 2643
			// (get) Token: 0x0600257A RID: 9594 RVA: 0x00098A38 File Offset: 0x00096C38
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaledBillboard._Start_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600257B RID: 9595 RVA: 0x00098A78 File Offset: 0x00096C78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503714, XrefRangeEnd = 503719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaledBillboard._Start_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A54 RID: 2644
			// (get) Token: 0x0600257C RID: 9596 RVA: 0x00098AAC File Offset: 0x00096CAC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaledBillboard._Start_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600257D RID: 9597 RVA: 0x0001371F File Offset: 0x0001191F
			public _Start_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A4F RID: 2639
			// (get) Token: 0x0600257E RID: 9598 RVA: 0x00098AEC File Offset: 0x00096CEC
			// (set) Token: 0x0600257F RID: 9599 RVA: 0x00013728 File Offset: 0x00011928
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaledBillboard._Start_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaledBillboard._Start_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A50 RID: 2640
			// (get) Token: 0x06002580 RID: 9600 RVA: 0x00098B14 File Offset: 0x00096D14
			// (set) Token: 0x06002581 RID: 9601 RVA: 0x00013743 File Offset: 0x00011943
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaledBillboard._Start_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaledBillboard._Start_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A51 RID: 2641
			// (get) Token: 0x06002582 RID: 9602 RVA: 0x00098B44 File Offset: 0x00096D44
			// (set) Token: 0x06002583 RID: 9603 RVA: 0x00013762 File Offset: 0x00011962
			public unsafe ScaledBillboard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaledBillboard._Start_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScaledBillboard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaledBillboard._Start_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A52 RID: 2642
			// (get) Token: 0x06002584 RID: 9604 RVA: 0x00098B74 File Offset: 0x00096D74
			// (set) Token: 0x06002585 RID: 9605 RVA: 0x00013781 File Offset: 0x00011981
			public unsafe KeyGrip _grip_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaledBillboard._Start_d__6.NativeFieldInfoPtr__grip_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeyGrip>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaledBillboard._Start_d__6.NativeFieldInfoPtr__grip_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001783 RID: 6019
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001784 RID: 6020
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001785 RID: 6021
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001786 RID: 6022
			private static readonly IntPtr NativeFieldInfoPtr__grip_5__2;

			// Token: 0x04001787 RID: 6023
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001788 RID: 6024
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001789 RID: 6025
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400178A RID: 6026
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400178B RID: 6027
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400178C RID: 6028
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
