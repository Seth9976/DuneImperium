using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace worm.match.components
{
	// Token: 0x020001D2 RID: 466
	public class WormAnimationSpeedToggle : MonoBehaviour
	{
		// Token: 0x0600149F RID: 5279 RVA: 0x00056AF0 File Offset: 0x00054CF0
		// Note: this type is marked as 'beforefieldinit'.
		static WormAnimationSpeedToggle()
		{
			Il2CppClassPointerStore<WormAnimationSpeedToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormAnimationSpeedToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAnimationSpeedToggle>.NativeClassPtr);
			WormAnimationSpeedToggle.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAnimationSpeedToggle>.NativeClassPtr, "slider");
			WormAnimationSpeedToggle.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAnimationSpeedToggle>.NativeClassPtr, 100666116);
			WormAnimationSpeedToggle.NativeMethodInfoPtr_InitSlider_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAnimationSpeedToggle>.NativeClassPtr, 100666117);
			WormAnimationSpeedToggle.NativeMethodInfoPtr_Event_SpeedChanged_Private_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAnimationSpeedToggle>.NativeClassPtr, 100666118);
			WormAnimationSpeedToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAnimationSpeedToggle>.NativeClassPtr, 100666119);
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x00056B84 File Offset: 0x00054D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714411, XrefRangeEnd = 714417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAnimationSpeedToggle.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x00056BB8 File Offset: 0x00054DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714417, XrefRangeEnd = 714422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InitSlider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAnimationSpeedToggle.NativeMethodInfoPtr_InitSlider_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x00056BF8 File Offset: 0x00054DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714422, XrefRangeEnd = 714430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Event_SpeedChanged(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAnimationSpeedToggle.NativeMethodInfoPtr_Event_SpeedChanged_Private_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x00056C2C File Offset: 0x00054E2C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAnimationSpeedToggle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAnimationSpeedToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAnimationSpeedToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x0000CA24 File Offset: 0x0000AC24
		public WormAnimationSpeedToggle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x00056C68 File Offset: 0x00054E68
		// (set) Token: 0x060014A6 RID: 5286 RVA: 0x0000CA2D File Offset: 0x0000AC2D
		public unsafe Slider slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAnimationSpeedToggle.NativeFieldInfoPtr_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAnimationSpeedToggle.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeFieldInfoPtr_slider;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeMethodInfoPtr_InitSlider_Private_IEnumerator_0;

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeMethodInfoPtr_Event_SpeedChanged_Private_Static_Void_Single_0;

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003D6 RID: 982
		[ObfuscatedName("worm.match.components.WormAnimationSpeedToggle+<>O")]
		public static class __O : global::Il2CppSystem.Object
		{
			// Token: 0x060027CC RID: 10188 RVA: 0x00015DBA File Offset: 0x00013FBA
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<WormAnimationSpeedToggle.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAnimationSpeedToggle>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAnimationSpeedToggle.__O>.NativeClassPtr);
				WormAnimationSpeedToggle.__O.NativeFieldInfoPtr__0___Event_SpeedChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAnimationSpeedToggle.__O>.NativeClassPtr, "<0>__Event_SpeedChanged");
			}

			// Token: 0x060027CD RID: 10189 RVA: 0x00015DEE File Offset: 0x00013FEE
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B1D RID: 2845
			// (get) Token: 0x060027CE RID: 10190 RVA: 0x00090D40 File Offset: 0x0008EF40
			// (set) Token: 0x060027CF RID: 10191 RVA: 0x00015DF7 File Offset: 0x00013FF7
			public unsafe static UnityAction<float> _0___Event_SpeedChanged
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAnimationSpeedToggle.__O.NativeFieldInfoPtr__0___Event_SpeedChanged, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAnimationSpeedToggle.__O.NativeFieldInfoPtr__0___Event_SpeedChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016EC RID: 5868
			private static readonly IntPtr NativeFieldInfoPtr__0___Event_SpeedChanged;
		}

		// Token: 0x020003D7 RID: 983
		[ObfuscatedName("worm.match.components.WormAnimationSpeedToggle+<InitSlider>d__2")]
		public sealed class _InitSlider_d__2 : global::Il2CppSystem.Object
		{
			// Token: 0x060027D0 RID: 10192 RVA: 0x00090D68 File Offset: 0x0008EF68
			// Note: this type is marked as 'beforefieldinit'.
			static _InitSlider_d__2()
			{
				Il2CppClassPointerStore<WormAnimationSpeedToggle._InitSlider_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAnimationSpeedToggle>.NativeClassPtr, "<InitSlider>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAnimationSpeedToggle._InitSlider_d__2>.NativeClassPtr);
				WormAnimationSpeedToggle._InitSlider_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAnimationSpeedToggle._InitSlider_d__2>.NativeClassPtr, "<>1__state");
				WormAnimationSpeedToggle._InitSlider_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAnimationSpeedToggle._InitSlider_d__2>.NativeClassPtr, "<>2__current");
				WormAnimationSpeedToggle._InitSlider_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAnimationSpeedToggle._InitSlider_d__2>.NativeClassPtr, "<>4__this");
				WormAnimationSpeedToggle._InitSlider_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAnimationSpeedToggle._InitSlider_d__2>.NativeClassPtr, 100666120);
				WormAnimationSpeedToggle._InitSlider_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAnimationSpeedToggle._InitSlider_d__2>.NativeClassPtr, 100666121);
				WormAnimationSpeedToggle._InitSlider_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAnimationSpeedToggle._InitSlider_d__2>.NativeClassPtr, 100666122);
				WormAnimationSpeedToggle._InitSlider_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAnimationSpeedToggle._InitSlider_d__2>.NativeClassPtr, 100666123);
				WormAnimationSpeedToggle._InitSlider_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAnimationSpeedToggle._InitSlider_d__2>.NativeClassPtr, 100666124);
				WormAnimationSpeedToggle._InitSlider_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAnimationSpeedToggle._InitSlider_d__2>.NativeClassPtr, 100666125);
			}

			// Token: 0x060027D1 RID: 10193 RVA: 0x00090E48 File Offset: 0x0008F048
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InitSlider_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAnimationSpeedToggle._InitSlider_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAnimationSpeedToggle._InitSlider_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060027D2 RID: 10194 RVA: 0x00090E90 File Offset: 0x0008F090
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAnimationSpeedToggle._InitSlider_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060027D3 RID: 10195 RVA: 0x00090EC4 File Offset: 0x0008F0C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714385, XrefRangeEnd = 714406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAnimationSpeedToggle._InitSlider_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B21 RID: 2849
			// (get) Token: 0x060027D4 RID: 10196 RVA: 0x00090F00 File Offset: 0x0008F100
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAnimationSpeedToggle._InitSlider_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060027D5 RID: 10197 RVA: 0x00090F40 File Offset: 0x0008F140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714406, XrefRangeEnd = 714411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAnimationSpeedToggle._InitSlider_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B22 RID: 2850
			// (get) Token: 0x060027D6 RID: 10198 RVA: 0x00090F74 File Offset: 0x0008F174
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAnimationSpeedToggle._InitSlider_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060027D7 RID: 10199 RVA: 0x00015E09 File Offset: 0x00014009
			public _InitSlider_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B1E RID: 2846
			// (get) Token: 0x060027D8 RID: 10200 RVA: 0x00090FB4 File Offset: 0x0008F1B4
			// (set) Token: 0x060027D9 RID: 10201 RVA: 0x00015E12 File Offset: 0x00014012
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAnimationSpeedToggle._InitSlider_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAnimationSpeedToggle._InitSlider_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B1F RID: 2847
			// (get) Token: 0x060027DA RID: 10202 RVA: 0x00090FDC File Offset: 0x0008F1DC
			// (set) Token: 0x060027DB RID: 10203 RVA: 0x00015E2D File Offset: 0x0001402D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAnimationSpeedToggle._InitSlider_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAnimationSpeedToggle._InitSlider_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B20 RID: 2848
			// (get) Token: 0x060027DC RID: 10204 RVA: 0x0009100C File Offset: 0x0008F20C
			// (set) Token: 0x060027DD RID: 10205 RVA: 0x00015E4C File Offset: 0x0001404C
			public unsafe WormAnimationSpeedToggle __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAnimationSpeedToggle._InitSlider_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAnimationSpeedToggle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAnimationSpeedToggle._InitSlider_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016ED RID: 5869
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016EE RID: 5870
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040016EF RID: 5871
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040016F0 RID: 5872
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040016F1 RID: 5873
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016F2 RID: 5874
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016F3 RID: 5875
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040016F4 RID: 5876
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016F5 RID: 5877
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
