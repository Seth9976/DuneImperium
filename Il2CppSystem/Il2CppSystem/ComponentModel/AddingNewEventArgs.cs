using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x020000F2 RID: 242
	public class AddingNewEventArgs : EventArgs
	{
		// Token: 0x06000FA5 RID: 4005 RVA: 0x00056E84 File Offset: 0x00055084
		// Note: this type is marked as 'beforefieldinit'.
		static AddingNewEventArgs()
		{
			Il2CppClassPointerStore<AddingNewEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "AddingNewEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddingNewEventArgs>.NativeClassPtr);
			AddingNewEventArgs.NativeFieldInfoPtr__NewObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddingNewEventArgs>.NativeClassPtr, "<NewObject>k__BackingField");
			AddingNewEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddingNewEventArgs>.NativeClassPtr, 100665551);
			AddingNewEventArgs.NativeMethodInfoPtr_get_NewObject_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddingNewEventArgs>.NativeClassPtr, 100665552);
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00056EF0 File Offset: 0x000550F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 456381, RefRangeEnd = 456382, XrefRangeStart = 456377, XrefRangeEnd = 456381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddingNewEventArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddingNewEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddingNewEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x00056F2C File Offset: 0x0005512C
		public unsafe Object NewObject
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddingNewEventArgs.NativeMethodInfoPtr_get_NewObject_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x00007A4C File Offset: 0x00005C4C
		public AddingNewEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x00056F6C File Offset: 0x0005516C
		// (set) Token: 0x06000FAA RID: 4010 RVA: 0x00007A55 File Offset: 0x00005C55
		public unsafe Object _NewObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddingNewEventArgs.NativeFieldInfoPtr__NewObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddingNewEventArgs.NativeFieldInfoPtr__NewObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeFieldInfoPtr__NewObject_k__BackingField;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeMethodInfoPtr_get_NewObject_Public_get_Object_0;
	}
}
