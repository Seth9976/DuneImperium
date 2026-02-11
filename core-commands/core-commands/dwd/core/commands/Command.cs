using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.commands
{
	// Token: 0x0200000F RID: 15
	public class Command : Object
	{
		// Token: 0x06000070 RID: 112 RVA: 0x00006214 File Offset: 0x00004414
		// Note: this type is marked as 'beforefieldinit'.
		static Command()
		{
			Il2CppClassPointerStore<Command>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.commands", "Command");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Command>.NativeClassPtr);
			Command.NativeFieldInfoPtr__Started_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Command>.NativeClassPtr, "<Started>k__BackingField");
			Command.NativeFieldInfoPtr__Completed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Command>.NativeClassPtr, "<Completed>k__BackingField");
			Command.NativeFieldInfoPtr_errorAlreadyThrown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Command>.NativeClassPtr, "errorAlreadyThrown");
			Command.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Command>.NativeClassPtr, "context");
			Command.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Command>.NativeClassPtr, 100663360);
			Command.NativeMethodInfoPtr_get_Started_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Command>.NativeClassPtr, 100663361);
			Command.NativeMethodInfoPtr_set_Started_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Command>.NativeClassPtr, 100663362);
			Command.NativeMethodInfoPtr_get_Completed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Command>.NativeClassPtr, 100663363);
			Command.NativeMethodInfoPtr_set_Completed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Command>.NativeClassPtr, 100663364);
			Command.NativeMethodInfoPtr_execute_Protected_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Command>.NativeClassPtr, 100663365);
			Command.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Command>.NativeClassPtr, 100663366);
			Command.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Command>.NativeClassPtr, 100663367);
			Command.NativeMethodInfoPtr_MarkCompleted_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Command>.NativeClassPtr, 100663368);
			Command.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Command>.NativeClassPtr, 100663369);
			Command.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Command>.NativeClassPtr, 100663370);
			Command.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Command>.NativeClassPtr, 100663371);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00006384 File Offset: 0x00004584
		[CallerCount(346)]
		[CachedScanResults(RefRangeStart = 1206264, RefRangeEnd = 1206610, XrefRangeStart = 1206259, XrefRangeEnd = 1206264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Command>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Command.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000063C0 File Offset: 0x000045C0
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000063FC File Offset: 0x000045FC
		public unsafe bool Started
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Command.NativeMethodInfoPtr_get_Started_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Command.NativeMethodInfoPtr_set_Started_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000643C File Offset: 0x0000463C
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00006478 File Offset: 0x00004678
		public unsafe virtual bool Completed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Command.NativeMethodInfoPtr_get_Completed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Command.NativeMethodInfoPtr_set_Completed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000064B8 File Offset: 0x000046B8
		[CallerCount(0)]
		public unsafe virtual IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Command.NativeMethodInfoPtr_execute_Protected_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00006504 File Offset: 0x00004704
		public unsafe virtual Object Current
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 1206619, RefRangeEnd = 1206639, XrefRangeStart = 1206610, XrefRangeEnd = 1206619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Command.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00006544 File Offset: 0x00004744
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1206643, RefRangeEnd = 1206667, XrefRangeStart = 1206639, XrefRangeEnd = 1206643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Command.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00006580 File Offset: 0x00004780
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1206667, RefRangeEnd = 1206672, XrefRangeStart = 1206667, XrefRangeEnd = 1206667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Command.NativeMethodInfoPtr_MarkCompleted_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000065B4 File Offset: 0x000047B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206672, XrefRangeEnd = 1206677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Command.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000065E8 File Offset: 0x000047E8
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Command.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00006628 File Offset: 0x00004828
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1206687, RefRangeEnd = 1206690, XrefRangeStart = 1206677, XrefRangeEnd = 1206687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Command.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000023BE File Offset: 0x000005BE
		public Command(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000666C File Offset: 0x0000486C
		// (set) Token: 0x0600007F RID: 127 RVA: 0x000023C7 File Offset: 0x000005C7
		public unsafe bool _Started_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Command.NativeFieldInfoPtr__Started_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Command.NativeFieldInfoPtr__Started_k__BackingField)) = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00006694 File Offset: 0x00004894
		// (set) Token: 0x06000081 RID: 129 RVA: 0x000023E2 File Offset: 0x000005E2
		public unsafe bool _Completed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Command.NativeFieldInfoPtr__Completed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Command.NativeFieldInfoPtr__Completed_k__BackingField)) = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000066BC File Offset: 0x000048BC
		// (set) Token: 0x06000083 RID: 131 RVA: 0x000023FD File Offset: 0x000005FD
		public unsafe bool errorAlreadyThrown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Command.NativeFieldInfoPtr_errorAlreadyThrown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Command.NativeFieldInfoPtr_errorAlreadyThrown)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000066E4 File Offset: 0x000048E4
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002418 File Offset: 0x00000618
		public unsafe IEnumerator context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Command.NativeFieldInfoPtr_context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Command.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr__Started_k__BackingField;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr__Completed_k__BackingField;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_errorAlreadyThrown;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_get_Started_Public_get_Boolean_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_set_Started_Private_set_Void_Boolean_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_get_Completed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_set_Completed_Private_set_Void_Boolean_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Abstract_Virtual_New_IEnumerator_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_MarkCompleted_Protected_Void_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
