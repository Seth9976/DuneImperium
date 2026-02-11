using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000441 RID: 1089
	public class LocalVariableInfo : Object
	{
		// Token: 0x06003EE4 RID: 16100 RVA: 0x0012D6FC File Offset: 0x0012B8FC
		// Note: this type is marked as 'beforefieldinit'.
		static LocalVariableInfo()
		{
			Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "LocalVariableInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr);
			LocalVariableInfo.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr, "type");
			LocalVariableInfo.NativeFieldInfoPtr_is_pinned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr, "is_pinned");
			LocalVariableInfo.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr, "position");
			LocalVariableInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr, 100672759);
			LocalVariableInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr, 100672760);
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x0012D790 File Offset: 0x0012B990
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalVariableInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalVariableInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x0012D7CC File Offset: 0x0012B9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401141, XrefRangeEnd = 1401151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalVariableInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x00016F95 File Offset: 0x00015195
		public LocalVariableInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06003EE8 RID: 16104 RVA: 0x0012D810 File Offset: 0x0012BA10
		// (set) Token: 0x06003EE9 RID: 16105 RVA: 0x00016F9E File Offset: 0x0001519E
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariableInfo.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariableInfo.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06003EEA RID: 16106 RVA: 0x0012D840 File Offset: 0x0012BA40
		// (set) Token: 0x06003EEB RID: 16107 RVA: 0x00016FBD File Offset: 0x000151BD
		public unsafe bool is_pinned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariableInfo.NativeFieldInfoPtr_is_pinned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariableInfo.NativeFieldInfoPtr_is_pinned)) = value;
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06003EEC RID: 16108 RVA: 0x0012D868 File Offset: 0x0012BA68
		// (set) Token: 0x06003EED RID: 16109 RVA: 0x00016FD8 File Offset: 0x000151D8
		public unsafe ushort position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariableInfo.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariableInfo.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x040033CF RID: 13263
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040033D0 RID: 13264
		private static readonly IntPtr NativeFieldInfoPtr_is_pinned;

		// Token: 0x040033D1 RID: 13265
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040033D2 RID: 13266
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040033D3 RID: 13267
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
