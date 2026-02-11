using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000004 RID: 4
	public class Button : Selectable
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00007C48 File Offset: 0x00005E48
		// Note: this type is marked as 'beforefieldinit'.
		static Button()
		{
			Il2CppClassPointerStore<Button>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Button");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Button>.NativeClassPtr);
			Button.NativeFieldInfoPtr_m_OnClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Button>.NativeClassPtr, "m_OnClick");
			Button.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100663310);
			Button.NativeMethodInfoPtr_get_onClick_Public_get_ButtonClickedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100663311);
			Button.NativeMethodInfoPtr_set_onClick_Public_set_Void_ButtonClickedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100663312);
			Button.NativeMethodInfoPtr_Press_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100663313);
			Button.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100663314);
			Button.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100663315);
			Button.NativeMethodInfoPtr_OnFinishSubmit_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100663316);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00007D18 File Offset: 0x00005F18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1081029, RefRangeEnd = 1081031, XrefRangeStart = 1081020, XrefRangeEnd = 1081029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Button()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Button>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00007D54 File Offset: 0x00005F54
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00007D94 File Offset: 0x00005F94
		public unsafe Button.ButtonClickedEvent onClick
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.NativeMethodInfoPtr_get_onClick_Public_get_ButtonClickedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Button.ButtonClickedEvent>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.NativeMethodInfoPtr_set_onClick_Public_set_Void_ButtonClickedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00007DD8 File Offset: 0x00005FD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1081035, RefRangeEnd = 1081037, XrefRangeStart = 1081031, XrefRangeEnd = 1081035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Press()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.NativeMethodInfoPtr_Press_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00007E0C File Offset: 0x0000600C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1081038, RefRangeEnd = 1081039, XrefRangeStart = 1081037, XrefRangeEnd = 1081038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Button.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00007E5C File Offset: 0x0000605C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1081046, RefRangeEnd = 1081047, XrefRangeStart = 1081039, XrefRangeEnd = 1081046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Button.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00007EAC File Offset: 0x000060AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081047, XrefRangeEnd = 1081052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnFinishSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.NativeMethodInfoPtr_OnFinishSubmit_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002157 File Offset: 0x00000357
		public Button(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00007EEC File Offset: 0x000060EC
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002160 File Offset: 0x00000360
		public unsafe Button.ButtonClickedEvent m_OnClick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button.NativeFieldInfoPtr_m_OnClick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button.ButtonClickedEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button.NativeFieldInfoPtr_m_OnClick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_m_OnClick;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_get_onClick_Public_get_ButtonClickedEvent_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_set_onClick_Public_set_Void_ButtonClickedEvent_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_Press_Private_Void_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_OnFinishSubmit_Private_IEnumerator_0;

		// Token: 0x02000079 RID: 121
		[Serializable]
		public class ButtonClickedEvent : UnityEvent
		{
			// Token: 0x06000BC0 RID: 3008 RVA: 0x000063B2 File Offset: 0x000045B2
			// Note: this type is marked as 'beforefieldinit'.
			static ButtonClickedEvent()
			{
				Il2CppClassPointerStore<Button.ButtonClickedEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Button>.NativeClassPtr, "ButtonClickedEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Button.ButtonClickedEvent>.NativeClassPtr);
				Button.ButtonClickedEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button.ButtonClickedEvent>.NativeClassPtr, 100663317);
			}

			// Token: 0x06000BC1 RID: 3009 RVA: 0x00034560 File Offset: 0x00032760
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081008, XrefRangeEnd = 1081009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ButtonClickedEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Button.ButtonClickedEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.ButtonClickedEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BC2 RID: 3010 RVA: 0x000063E6 File Offset: 0x000045E6
			public ButtonClickedEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040008DE RID: 2270
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200007A RID: 122
		[ObfuscatedName("UnityEngine.UI.Button+<OnFinishSubmit>d__9")]
		public sealed class _OnFinishSubmit_d__9 : Object
		{
			// Token: 0x06000BC3 RID: 3011 RVA: 0x0003459C File Offset: 0x0003279C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnFinishSubmit_d__9()
			{
				Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Button>.NativeClassPtr, "<OnFinishSubmit>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr);
				Button._OnFinishSubmit_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr, "<>1__state");
				Button._OnFinishSubmit_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr, "<>2__current");
				Button._OnFinishSubmit_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr, "<>4__this");
				Button._OnFinishSubmit_d__9.NativeFieldInfoPtr__fadeTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr, "<fadeTime>5__2");
				Button._OnFinishSubmit_d__9.NativeFieldInfoPtr__elapsedTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr, "<elapsedTime>5__3");
				Button._OnFinishSubmit_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr, 100663318);
				Button._OnFinishSubmit_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr, 100663319);
				Button._OnFinishSubmit_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr, 100663320);
				Button._OnFinishSubmit_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr, 100663321);
				Button._OnFinishSubmit_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr, 100663322);
				Button._OnFinishSubmit_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr, 100663323);
			}

			// Token: 0x06000BC4 RID: 3012 RVA: 0x000346A4 File Offset: 0x000328A4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnFinishSubmit_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Button._OnFinishSubmit_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button._OnFinishSubmit_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000BC5 RID: 3013 RVA: 0x000346EC File Offset: 0x000328EC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button._OnFinishSubmit_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BC6 RID: 3014 RVA: 0x00034720 File Offset: 0x00032920
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081009, XrefRangeEnd = 1081015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button._OnFinishSubmit_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170003F2 RID: 1010
			// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x0003475C File Offset: 0x0003295C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button._OnFinishSubmit_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000BC8 RID: 3016 RVA: 0x0003479C File Offset: 0x0003299C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081015, XrefRangeEnd = 1081020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button._OnFinishSubmit_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003F3 RID: 1011
			// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x000347D0 File Offset: 0x000329D0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button._OnFinishSubmit_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000BCA RID: 3018 RVA: 0x000063EF File Offset: 0x000045EF
			public _OnFinishSubmit_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003ED RID: 1005
			// (get) Token: 0x06000BCB RID: 3019 RVA: 0x00034810 File Offset: 0x00032A10
			// (set) Token: 0x06000BCC RID: 3020 RVA: 0x000063F8 File Offset: 0x000045F8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button._OnFinishSubmit_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button._OnFinishSubmit_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003EE RID: 1006
			// (get) Token: 0x06000BCD RID: 3021 RVA: 0x00034838 File Offset: 0x00032A38
			// (set) Token: 0x06000BCE RID: 3022 RVA: 0x00006413 File Offset: 0x00004613
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button._OnFinishSubmit_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button._OnFinishSubmit_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003EF RID: 1007
			// (get) Token: 0x06000BCF RID: 3023 RVA: 0x00034868 File Offset: 0x00032A68
			// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x00006432 File Offset: 0x00004632
			public unsafe Button __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button._OnFinishSubmit_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button._OnFinishSubmit_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003F0 RID: 1008
			// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x00034898 File Offset: 0x00032A98
			// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x00006451 File Offset: 0x00004651
			public unsafe float _fadeTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button._OnFinishSubmit_d__9.NativeFieldInfoPtr__fadeTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button._OnFinishSubmit_d__9.NativeFieldInfoPtr__fadeTime_5__2)) = value;
				}
			}

			// Token: 0x170003F1 RID: 1009
			// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x000348C0 File Offset: 0x00032AC0
			// (set) Token: 0x06000BD4 RID: 3028 RVA: 0x0000646C File Offset: 0x0000466C
			public unsafe float _elapsedTime_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button._OnFinishSubmit_d__9.NativeFieldInfoPtr__elapsedTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button._OnFinishSubmit_d__9.NativeFieldInfoPtr__elapsedTime_5__3)) = value;
				}
			}

			// Token: 0x040008DF RID: 2271
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040008E0 RID: 2272
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040008E1 RID: 2273
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040008E2 RID: 2274
			private static readonly IntPtr NativeFieldInfoPtr__fadeTime_5__2;

			// Token: 0x040008E3 RID: 2275
			private static readonly IntPtr NativeFieldInfoPtr__elapsedTime_5__3;

			// Token: 0x040008E4 RID: 2276
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040008E5 RID: 2277
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008E6 RID: 2278
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040008E7 RID: 2279
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040008E8 RID: 2280
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008E9 RID: 2281
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
