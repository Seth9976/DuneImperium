using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C8 RID: 200
	public class CommandEventBase<T> : EventBase<T> where T : CommandEventBase<T>, new()
	{
		// Token: 0x060011C7 RID: 4551 RVA: 0x0005B2B4 File Offset: 0x000594B4
		// Note: this type is marked as 'beforefieldinit'.
		static CommandEventBase()
		{
			Il2CppClassPointerStore<CommandEventBase<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "CommandEventBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandEventBase<T>>.NativeClassPtr);
			CommandEventBase<T>.NativeFieldInfoPtr_m_CommandName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandEventBase<T>>.NativeClassPtr, "m_CommandName");
			CommandEventBase<T>.NativeMethodInfoPtr_get_commandName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandEventBase<T>>.NativeClassPtr, 100665813);
			CommandEventBase<T>.NativeMethodInfoPtr_set_commandName_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandEventBase<T>>.NativeClassPtr, 100665814);
			CommandEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandEventBase<T>>.NativeClassPtr, 100665815);
			CommandEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandEventBase<T>>.NativeClassPtr, 100665816);
			CommandEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandEventBase<T>>.NativeClassPtr, 100665817);
			CommandEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandEventBase<T>>.NativeClassPtr, 100665818);
			CommandEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandEventBase<T>>.NativeClassPtr, 100665819);
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x0005B3C0 File Offset: 0x000595C0
		// (set) Token: 0x060011C9 RID: 4553 RVA: 0x0005B3F8 File Offset: 0x000595F8
		public unsafe virtual string commandName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 311989, RefRangeEnd = 311996, XrefRangeStart = 311986, XrefRangeEnd = 311989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandEventBase<T>.NativeMethodInfoPtr_get_commandName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandEventBase<T>.NativeMethodInfoPtr_set_commandName_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0005B43C File Offset: 0x0005963C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311996, XrefRangeEnd = 311999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CommandEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0005B478 File Offset: 0x00059678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311999, XrefRangeEnd = 312001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x0005B4AC File Offset: 0x000596AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312007, RefRangeEnd = 312009, XrefRangeStart = 312001, XrefRangeEnd = 312007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(Event systemEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x0005B4EC File Offset: 0x000596EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312016, RefRangeEnd = 312017, XrefRangeStart = 312009, XrefRangeEnd = 312016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(string commandName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(commandName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0005B52C File Offset: 0x0005972C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 312022, RefRangeEnd = 312026, XrefRangeStart = 312017, XrefRangeEnd = 312022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommandEventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandEventBase<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x00008E9B File Offset: 0x0000709B
		public CommandEventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x0005B568 File Offset: 0x00059768
		// (set) Token: 0x060011D1 RID: 4561 RVA: 0x00008EA4 File Offset: 0x000070A4
		public unsafe string m_CommandName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandEventBase<T>.NativeFieldInfoPtr_m_CommandName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandEventBase<T>.NativeFieldInfoPtr_m_CommandName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeFieldInfoPtr_m_CommandName;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeMethodInfoPtr_get_commandName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeMethodInfoPtr_set_commandName_Protected_set_Void_String_0;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_String_0;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
