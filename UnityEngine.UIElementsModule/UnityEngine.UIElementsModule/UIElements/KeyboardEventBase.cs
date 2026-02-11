using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000EC RID: 236
	public class KeyboardEventBase<T> : EventBase<T> where T : KeyboardEventBase<T>, new()
	{
		// Token: 0x06001382 RID: 4994 RVA: 0x00061858 File Offset: 0x0005FA58
		// Note: this type is marked as 'beforefieldinit'.
		static KeyboardEventBase()
		{
			Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "KeyboardEventBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr);
			KeyboardEventBase<T>.NativeFieldInfoPtr__modifiers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, "<modifiers>k__BackingField");
			KeyboardEventBase<T>.NativeFieldInfoPtr__character_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, "<character>k__BackingField");
			KeyboardEventBase<T>.NativeFieldInfoPtr__keyCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, "<keyCode>k__BackingField");
			KeyboardEventBase<T>.NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100666067);
			KeyboardEventBase<T>.NativeMethodInfoPtr_set_modifiers_Protected_set_Void_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100666068);
			KeyboardEventBase<T>.NativeMethodInfoPtr_get_character_Public_Virtual_Final_New_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100666069);
			KeyboardEventBase<T>.NativeMethodInfoPtr_set_character_Protected_set_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100666070);
			KeyboardEventBase<T>.NativeMethodInfoPtr_get_keyCode_Public_Virtual_Final_New_get_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100666071);
			KeyboardEventBase<T>.NativeMethodInfoPtr_set_keyCode_Protected_set_Void_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100666072);
			KeyboardEventBase<T>.NativeMethodInfoPtr_get_shiftKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100666073);
			KeyboardEventBase<T>.NativeMethodInfoPtr_get_ctrlKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100666074);
			KeyboardEventBase<T>.NativeMethodInfoPtr_get_commandKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100666075);
			KeyboardEventBase<T>.NativeMethodInfoPtr_get_altKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100666076);
			KeyboardEventBase<T>.NativeMethodInfoPtr_get_functionKey_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100666077);
			KeyboardEventBase<T>.NativeMethodInfoPtr_get_actionKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100666078);
			KeyboardEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100666079);
			KeyboardEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100666080);
			KeyboardEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100666081);
			KeyboardEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr, 100666082);
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x00061A40 File Offset: 0x0005FC40
		// (set) Token: 0x06001384 RID: 4996 RVA: 0x00061A7C File Offset: 0x0005FC7C
		public unsafe virtual EventModifiers modifiers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventBase<T>.NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventBase<T>.NativeMethodInfoPtr_set_modifiers_Protected_set_Void_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x00061ABC File Offset: 0x0005FCBC
		// (set) Token: 0x06001386 RID: 4998 RVA: 0x00061AF8 File Offset: 0x0005FCF8
		public unsafe virtual char character
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventBase<T>.NativeMethodInfoPtr_get_character_Public_Virtual_Final_New_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventBase<T>.NativeMethodInfoPtr_set_character_Protected_set_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x00061B38 File Offset: 0x0005FD38
		// (set) Token: 0x06001388 RID: 5000 RVA: 0x00061B74 File Offset: 0x0005FD74
		public unsafe virtual KeyCode keyCode
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 311826, RefRangeEnd = 311839, XrefRangeStart = 311826, XrefRangeEnd = 311839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventBase<T>.NativeMethodInfoPtr_get_keyCode_Public_Virtual_Final_New_get_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventBase<T>.NativeMethodInfoPtr_set_keyCode_Protected_set_Void_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x00061BB4 File Offset: 0x0005FDB4
		public unsafe virtual bool shiftKey
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 314188, RefRangeEnd = 314194, XrefRangeStart = 314188, XrefRangeEnd = 314188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventBase<T>.NativeMethodInfoPtr_get_shiftKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x00061BF0 File Offset: 0x0005FDF0
		public unsafe virtual bool ctrlKey
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 314194, RefRangeEnd = 314196, XrefRangeStart = 314194, XrefRangeEnd = 314194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventBase<T>.NativeMethodInfoPtr_get_ctrlKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x00061C2C File Offset: 0x0005FE2C
		public unsafe virtual bool commandKey
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 314196, RefRangeEnd = 314198, XrefRangeStart = 314196, XrefRangeEnd = 314196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventBase<T>.NativeMethodInfoPtr_get_commandKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x00061C68 File Offset: 0x0005FE68
		public unsafe virtual bool altKey
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 314198, RefRangeEnd = 314202, XrefRangeStart = 314198, XrefRangeEnd = 314198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventBase<T>.NativeMethodInfoPtr_get_altKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x00061CA4 File Offset: 0x0005FEA4
		public unsafe bool functionKey
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 314202, RefRangeEnd = 314204, XrefRangeStart = 314202, XrefRangeEnd = 314202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventBase<T>.NativeMethodInfoPtr_get_functionKey_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x00061CE0 File Offset: 0x0005FEE0
		public unsafe virtual bool actionKey
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 314208, RefRangeEnd = 314211, XrefRangeStart = 314204, XrefRangeEnd = 314208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventBase<T>.NativeMethodInfoPtr_get_actionKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00061D1C File Offset: 0x0005FF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314211, XrefRangeEnd = 314212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyboardEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x00061D58 File Offset: 0x0005FF58
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x00061D8C File Offset: 0x0005FF8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 314224, RefRangeEnd = 314226, XrefRangeStart = 314212, XrefRangeEnd = 314224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(Event systemEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x00061DCC File Offset: 0x0005FFCC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 314229, RefRangeEnd = 314233, XrefRangeStart = 314226, XrefRangeEnd = 314229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyboardEventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyboardEventBase<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00009821 File Offset: 0x00007A21
		public KeyboardEventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x00061E08 File Offset: 0x00060008
		// (set) Token: 0x06001395 RID: 5013 RVA: 0x0000982A File Offset: 0x00007A2A
		public unsafe EventModifiers _modifiers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardEventBase<T>.NativeFieldInfoPtr__modifiers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardEventBase<T>.NativeFieldInfoPtr__modifiers_k__BackingField)) = value;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x00061E30 File Offset: 0x00060030
		// (set) Token: 0x06001397 RID: 5015 RVA: 0x00009845 File Offset: 0x00007A45
		public unsafe char _character_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardEventBase<T>.NativeFieldInfoPtr__character_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardEventBase<T>.NativeFieldInfoPtr__character_k__BackingField)) = value;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x00061E58 File Offset: 0x00060058
		// (set) Token: 0x06001399 RID: 5017 RVA: 0x00009860 File Offset: 0x00007A60
		public unsafe KeyCode _keyCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardEventBase<T>.NativeFieldInfoPtr__keyCode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardEventBase<T>.NativeFieldInfoPtr__keyCode_k__BackingField)) = value;
			}
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x00061E80 File Offset: 0x00060080
		public static T GetPooled(char c, KeyCode keyCode, EventModifiers modifiers)
		{
			T pooled = EventBase<T>.GetPooled();
			pooled.modifiers = modifiers;
			pooled.character = c;
			pooled.keyCode = keyCode;
			return pooled;
		}

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeFieldInfoPtr__modifiers_k__BackingField;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeFieldInfoPtr__character_k__BackingField;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeFieldInfoPtr__keyCode_k__BackingField;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0;

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeMethodInfoPtr_set_modifiers_Protected_set_Void_EventModifiers_0;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeMethodInfoPtr_get_character_Public_Virtual_Final_New_get_Char_0;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeMethodInfoPtr_set_character_Protected_set_Void_Char_0;

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeMethodInfoPtr_get_keyCode_Public_Virtual_Final_New_get_KeyCode_0;

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeMethodInfoPtr_set_keyCode_Protected_set_Void_KeyCode_0;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeMethodInfoPtr_get_shiftKey_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeMethodInfoPtr_get_ctrlKey_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeMethodInfoPtr_get_commandKey_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D56 RID: 3414
		private static readonly IntPtr NativeMethodInfoPtr_get_altKey_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D57 RID: 3415
		private static readonly IntPtr NativeMethodInfoPtr_get_functionKey_Internal_get_Boolean_0;

		// Token: 0x04000D58 RID: 3416
		private static readonly IntPtr NativeMethodInfoPtr_get_actionKey_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D59 RID: 3417
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000D5A RID: 3418
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000D5B RID: 3419
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0;

		// Token: 0x04000D5C RID: 3420
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
