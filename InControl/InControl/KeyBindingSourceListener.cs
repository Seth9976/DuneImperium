using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x02000015 RID: 21
	public class KeyBindingSourceListener : Object
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x0000A264 File Offset: 0x00008464
		// Note: this type is marked as 'beforefieldinit'.
		static KeyBindingSourceListener()
		{
			Il2CppClassPointerStore<KeyBindingSourceListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "KeyBindingSourceListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyBindingSourceListener>.NativeClassPtr);
			KeyBindingSourceListener.NativeFieldInfoPtr_detectFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyBindingSourceListener>.NativeClassPtr, "detectFound");
			KeyBindingSourceListener.NativeFieldInfoPtr_detectPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyBindingSourceListener>.NativeClassPtr, "detectPhase");
			KeyBindingSourceListener.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBindingSourceListener>.NativeClassPtr, 100663407);
			KeyBindingSourceListener.NativeMethodInfoPtr_Listen_Public_Virtual_Final_New_BindingSource_BindingListenOptions_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBindingSourceListener>.NativeClassPtr, 100663408);
			KeyBindingSourceListener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBindingSourceListener>.NativeClassPtr, 100663409);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000A2F8 File Offset: 0x000084F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767687, XrefRangeEnd = 767690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyBindingSourceListener.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000A32C File Offset: 0x0000852C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767690, XrefRangeEnd = 767703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual BindingSource Listen(BindingListenOptions listenOptions, InputDevice device)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listenOptions);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(device);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyBindingSourceListener.NativeMethodInfoPtr_Listen_Public_Virtual_Final_New_BindingSource_BindingListenOptions_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BindingSource>(intPtr3) : null;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000A390 File Offset: 0x00008590
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyBindingSourceListener()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyBindingSourceListener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyBindingSourceListener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002373 File Offset: 0x00000573
		public KeyBindingSourceListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000A3CC File Offset: 0x000085CC
		// (set) Token: 0x060000BA RID: 186 RVA: 0x0000237C File Offset: 0x0000057C
		public unsafe KeyCombo detectFound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyBindingSourceListener.NativeFieldInfoPtr_detectFound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyBindingSourceListener.NativeFieldInfoPtr_detectFound)) = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000A3F4 File Offset: 0x000085F4
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00002397 File Offset: 0x00000597
		public unsafe int detectPhase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyBindingSourceListener.NativeFieldInfoPtr_detectPhase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyBindingSourceListener.NativeFieldInfoPtr_detectPhase)) = value;
			}
		}

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeFieldInfoPtr_detectFound;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeFieldInfoPtr_detectPhase;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_Listen_Public_Virtual_Final_New_BindingSource_BindingListenOptions_InputDevice_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
