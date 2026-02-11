using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppMicrosoft.Extensions.Options
{
	// Token: 0x0200001C RID: 28
	public class OptionsMonitor<TOptions> : Object where TOptions : class
	{
		// Token: 0x0600007A RID: 122 RVA: 0x000043F8 File Offset: 0x000025F8
		// Note: this type is marked as 'beforefieldinit'.
		static OptionsMonitor()
		{
			Il2CppClassPointerStore<OptionsMonitor<TOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "Microsoft.Extensions.Options", "OptionsMonitor`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsMonitor<TOptions>>.NativeClassPtr);
			OptionsMonitor<TOptions>.NativeFieldInfoPtr__cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsMonitor<TOptions>>.NativeClassPtr, "_cache");
			OptionsMonitor<TOptions>.NativeFieldInfoPtr__factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsMonitor<TOptions>>.NativeClassPtr, "_factory");
			OptionsMonitor<TOptions>.NativeFieldInfoPtr__registrations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsMonitor<TOptions>>.NativeClassPtr, "_registrations");
			OptionsMonitor<TOptions>.NativeFieldInfoPtr__onChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsMonitor<TOptions>>.NativeClassPtr, "_onChange");
			OptionsMonitor<TOptions>.NativeMethodInfoPtr_add__onChange_Internal_add_Void_Action_2_TOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMonitor<TOptions>>.NativeClassPtr, 100663349);
			OptionsMonitor<TOptions>.NativeMethodInfoPtr_remove__onChange_Internal_rem_Void_Action_2_TOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMonitor<TOptions>>.NativeClassPtr, 100663350);
			OptionsMonitor<TOptions>.NativeMethodInfoPtr__ctor_Public_Void_IOptionsFactory_1_TOptions_IEnumerable_1_IOptionsChangeTokenSource_1_TOptions_IOptionsMonitorCache_1_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMonitor<TOptions>>.NativeClassPtr, 100663351);
			OptionsMonitor<TOptions>.NativeMethodInfoPtr_InvokeChanged_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMonitor<TOptions>>.NativeClassPtr, 100663352);
			OptionsMonitor<TOptions>.NativeMethodInfoPtr_get_CurrentValue_Public_Virtual_Final_New_get_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMonitor<TOptions>>.NativeClassPtr, 100663353);
			OptionsMonitor<TOptions>.NativeMethodInfoPtr_Get_Public_Virtual_New_TOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMonitor<TOptions>>.NativeClassPtr, 100663354);
			OptionsMonitor<TOptions>.NativeMethodInfoPtr_OnChange_Public_Virtual_Final_New_IDisposable_Action_2_TOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMonitor<TOptions>>.NativeClassPtr, 100663355);
			OptionsMonitor<TOptions>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMonitor<TOptions>>.NativeClassPtr, 100663356);
			OptionsMonitor<TOptions>.NativeMethodInfoPtr_Method_Private_Void_IOptionsChangeTokenSource_1_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMonitor<TOptions>>.NativeClassPtr, 100663357);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004568 File Offset: 0x00002768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265883, XrefRangeEnd = 1265888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__onChange(Action<TOptions, string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsMonitor<TOptions>.NativeMethodInfoPtr_add__onChange_Internal_add_Void_Action_2_TOptions_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000045AC File Offset: 0x000027AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1265893, RefRangeEnd = 1265894, XrefRangeStart = 1265888, XrefRangeEnd = 1265893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__onChange(Action<TOptions, string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsMonitor<TOptions>.NativeMethodInfoPtr_remove__onChange_Internal_rem_Void_Action_2_TOptions_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000045F0 File Offset: 0x000027F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265894, XrefRangeEnd = 1265925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionsMonitor(IOptionsFactory<TOptions> factory, IEnumerable<IOptionsChangeTokenSource<TOptions>> sources, IOptionsMonitorCache<TOptions> cache)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsMonitor<TOptions>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sources);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cache);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsMonitor<TOptions>.NativeMethodInfoPtr__ctor_Public_Void_IOptionsFactory_1_TOptions_IEnumerable_1_IOptionsChangeTokenSource_1_TOptions_IOptionsMonitorCache_1_TOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004660 File Offset: 0x00002860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265925, XrefRangeEnd = 1265931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeChanged(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsMonitor<TOptions>.NativeMethodInfoPtr_InvokeChanged_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000046A4 File Offset: 0x000028A4
		public unsafe virtual TOptions CurrentValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265931, XrefRangeEnd = 1265935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsMonitor<TOptions>.NativeMethodInfoPtr_get_CurrentValue_Public_Virtual_Final_New_get_TOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TOptions>(intPtr, false, true);
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000046E0 File Offset: 0x000028E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265935, XrefRangeEnd = 1265950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TOptions Get(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionsMonitor<TOptions>.NativeMethodInfoPtr_Get_Public_Virtual_New_TOptions_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TOptions>(intPtr, false, true);
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004738 File Offset: 0x00002938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265950, XrefRangeEnd = 1265961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDisposable OnChange(Action<TOptions, string> listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsMonitor<TOptions>.NativeMethodInfoPtr_OnChange_Public_Virtual_Final_New_IDisposable_Action_2_TOptions_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr3) : null;
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004788 File Offset: 0x00002988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265961, XrefRangeEnd = 1265981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsMonitor<TOptions>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000047BC File Offset: 0x000029BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1266004, RefRangeEnd = 1266006, XrefRangeStart = 1265981, XrefRangeEnd = 1266004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_IOptionsChangeTokenSource_1_TOptions_0(IOptionsChangeTokenSource<TOptions> source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsMonitor<TOptions>.NativeMethodInfoPtr_Method_Private_Void_IOptionsChangeTokenSource_1_TOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000023AB File Offset: 0x000005AB
		public OptionsMonitor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00004800 File Offset: 0x00002A00
		// (set) Token: 0x06000086 RID: 134 RVA: 0x000023B4 File Offset: 0x000005B4
		public unsafe IOptionsMonitorCache<TOptions> _cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsMonitor<TOptions>.NativeFieldInfoPtr__cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOptionsMonitorCache<TOptions>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsMonitor<TOptions>.NativeFieldInfoPtr__cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00004830 File Offset: 0x00002A30
		// (set) Token: 0x06000088 RID: 136 RVA: 0x000023D3 File Offset: 0x000005D3
		public unsafe IOptionsFactory<TOptions> _factory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsMonitor<TOptions>.NativeFieldInfoPtr__factory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOptionsFactory<TOptions>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsMonitor<TOptions>.NativeFieldInfoPtr__factory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00004860 File Offset: 0x00002A60
		// (set) Token: 0x0600008A RID: 138 RVA: 0x000023F2 File Offset: 0x000005F2
		public unsafe List<IDisposable> _registrations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsMonitor<TOptions>.NativeFieldInfoPtr__registrations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IDisposable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsMonitor<TOptions>.NativeFieldInfoPtr__registrations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00004890 File Offset: 0x00002A90
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002411 File Offset: 0x00000611
		public unsafe Action<TOptions, string> _onChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsMonitor<TOptions>.NativeFieldInfoPtr__onChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TOptions, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsMonitor<TOptions>.NativeFieldInfoPtr__onChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr__cache;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr__factory;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr__registrations;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr__onChange;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_add__onChange_Internal_add_Void_Action_2_TOptions_String_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_remove__onChange_Internal_rem_Void_Action_2_TOptions_String_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IOptionsFactory_1_TOptions_IEnumerable_1_IOptionsChangeTokenSource_1_TOptions_IOptionsMonitorCache_1_TOptions_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_InvokeChanged_Private_Void_String_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentValue_Public_Virtual_Final_New_get_TOptions_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_New_TOptions_String_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_OnChange_Public_Virtual_Final_New_IDisposable_Action_2_TOptions_String_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_IOptionsChangeTokenSource_1_TOptions_0;

		// Token: 0x02000027 RID: 39
		public sealed class ChangeTrackerDisposable : Object
		{
			// Token: 0x060000E3 RID: 227 RVA: 0x00005A54 File Offset: 0x00003C54
			// Note: this type is marked as 'beforefieldinit'.
			static ChangeTrackerDisposable()
			{
				Il2CppClassPointerStore<OptionsMonitor<TOptions>.ChangeTrackerDisposable>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsMonitor<TOptions>>.NativeClassPtr, "ChangeTrackerDisposable"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsMonitor<TOptions>.ChangeTrackerDisposable>.NativeClassPtr);
				OptionsMonitor<TOptions>.ChangeTrackerDisposable.NativeFieldInfoPtr__listener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsMonitor<TOptions>.ChangeTrackerDisposable>.NativeClassPtr, "_listener");
				OptionsMonitor<TOptions>.ChangeTrackerDisposable.NativeFieldInfoPtr__monitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsMonitor<TOptions>.ChangeTrackerDisposable>.NativeClassPtr, "_monitor");
				OptionsMonitor<TOptions>.ChangeTrackerDisposable.NativeMethodInfoPtr__ctor_Public_Void_OptionsMonitor_1_TOptions_Action_2_TOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMonitor<TOptions>.ChangeTrackerDisposable>.NativeClassPtr, 100663358);
				OptionsMonitor<TOptions>.ChangeTrackerDisposable.NativeMethodInfoPtr_OnChange_Public_Void_TOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMonitor<TOptions>.ChangeTrackerDisposable>.NativeClassPtr, 100663359);
				OptionsMonitor<TOptions>.ChangeTrackerDisposable.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMonitor<TOptions>.ChangeTrackerDisposable>.NativeClassPtr, 100663360);
			}

			// Token: 0x060000E4 RID: 228 RVA: 0x00005B20 File Offset: 0x00003D20
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1138610, RefRangeEnd = 1138611, XrefRangeStart = 1138610, XrefRangeEnd = 1138611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ChangeTrackerDisposable(OptionsMonitor<TOptions> monitor, Action<TOptions, string> listener)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsMonitor<TOptions>.ChangeTrackerDisposable>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(monitor);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsMonitor<TOptions>.ChangeTrackerDisposable.NativeMethodInfoPtr__ctor_Public_Void_OptionsMonitor_1_TOptions_Action_2_TOptions_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000E5 RID: 229 RVA: 0x00005B80 File Offset: 0x00003D80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265874, XrefRangeEnd = 1265875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnChange(TOptions options, string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TOptions).IsValueType)
					{
						TOptions toptions = options;
						intPtr = ((toptions is string) ? IL2CPP.ManagedStringToIl2Cpp(toptions as string) : IL2CPP.Il2CppObjectBaseToPtr(toptions as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref options;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(OptionsMonitor<TOptions>.ChangeTrackerDisposable.NativeMethodInfoPtr_OnChange_Public_Void_TOptions_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x060000E6 RID: 230 RVA: 0x00005C0C File Offset: 0x00003E0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265875, XrefRangeEnd = 1265880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsMonitor<TOptions>.ChangeTrackerDisposable.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000E7 RID: 231 RVA: 0x000026FA File Offset: 0x000008FA
			public ChangeTrackerDisposable(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x060000E8 RID: 232 RVA: 0x00005C40 File Offset: 0x00003E40
			// (set) Token: 0x060000E9 RID: 233 RVA: 0x00002703 File Offset: 0x00000903
			public unsafe Action<TOptions, string> _listener
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsMonitor<TOptions>.ChangeTrackerDisposable.NativeFieldInfoPtr__listener);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TOptions, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsMonitor<TOptions>.ChangeTrackerDisposable.NativeFieldInfoPtr__listener), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x060000EA RID: 234 RVA: 0x00005C70 File Offset: 0x00003E70
			// (set) Token: 0x060000EB RID: 235 RVA: 0x00002722 File Offset: 0x00000922
			public unsafe OptionsMonitor<TOptions> _monitor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsMonitor<TOptions>.ChangeTrackerDisposable.NativeFieldInfoPtr__monitor);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptionsMonitor<TOptions>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsMonitor<TOptions>.ChangeTrackerDisposable.NativeFieldInfoPtr__monitor), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000083 RID: 131
			private static readonly IntPtr NativeFieldInfoPtr__listener;

			// Token: 0x04000084 RID: 132
			private static readonly IntPtr NativeFieldInfoPtr__monitor;

			// Token: 0x04000085 RID: 133
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_OptionsMonitor_1_TOptions_Action_2_TOptions_String_0;

			// Token: 0x04000086 RID: 134
			private static readonly IntPtr NativeMethodInfoPtr_OnChange_Public_Void_TOptions_String_0;

			// Token: 0x04000087 RID: 135
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000028 RID: 40
		[ObfuscatedName("Microsoft.Extensions.Options.OptionsMonitor`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060000EC RID: 236 RVA: 0x00005CA0 File Offset: 0x00003EA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<OptionsMonitor<TOptions>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsMonitor<TOptions>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsMonitor<TOptions>.__c>.NativeClassPtr);
				OptionsMonitor<TOptions>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsMonitor<TOptions>.__c>.NativeClassPtr, "<>9");
				OptionsMonitor<TOptions>.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsMonitor<TOptions>.__c>.NativeClassPtr, "<>9__10_0");
				OptionsMonitor<TOptions>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMonitor<TOptions>.__c>.NativeClassPtr, 100663362);
				OptionsMonitor<TOptions>.__c.NativeMethodInfoPtr__Get_b__10_0_Internal_TOptions_String_IOptionsFactory_1_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMonitor<TOptions>.__c>.NativeClassPtr, 100663363);
			}

			// Token: 0x060000ED RID: 237 RVA: 0x00005D58 File Offset: 0x00003F58
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsMonitor<TOptions>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsMonitor<TOptions>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000EE RID: 238 RVA: 0x00005D94 File Offset: 0x00003F94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265880, XrefRangeEnd = 1265883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TOptions _Get_b__10_0(string name, IOptionsFactory<TOptions> factory)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(factory);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsMonitor<TOptions>.__c.NativeMethodInfoPtr__Get_b__10_0_Internal_TOptions_String_IOptionsFactory_1_TOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TOptions>(intPtr, false, true);
			}

			// Token: 0x060000EF RID: 239 RVA: 0x00002741 File Offset: 0x00000941
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x060000F0 RID: 240 RVA: 0x00005DF0 File Offset: 0x00003FF0
			// (set) Token: 0x060000F1 RID: 241 RVA: 0x0000274A File Offset: 0x0000094A
			public unsafe static OptionsMonitor<TOptions>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OptionsMonitor<TOptions>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptionsMonitor<TOptions>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OptionsMonitor<TOptions>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x060000F2 RID: 242 RVA: 0x00005E18 File Offset: 0x00004018
			// (set) Token: 0x060000F3 RID: 243 RVA: 0x0000275C File Offset: 0x0000095C
			public unsafe static Func<string, IOptionsFactory<TOptions>, TOptions> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OptionsMonitor<TOptions>.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, IOptionsFactory<TOptions>, TOptions>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OptionsMonitor<TOptions>.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000088 RID: 136
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000089 RID: 137
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x0400008A RID: 138
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400008B RID: 139
			private static readonly IntPtr NativeMethodInfoPtr__Get_b__10_0_Internal_TOptions_String_IOptionsFactory_1_TOptions_0;
		}

		// Token: 0x02000029 RID: 41
		[ObfuscatedName("Microsoft.Extensions.Options.OptionsMonitor`1+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x060000F4 RID: 244 RVA: 0x00005E40 File Offset: 0x00004040
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<OptionsMonitor<TOptions>.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsMonitor<TOptions>>.NativeClassPtr, "<>c__DisplayClass10_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsMonitor<TOptions>.__c__DisplayClass10_0>.NativeClassPtr);
				OptionsMonitor<TOptions>.__c__DisplayClass10_0.NativeFieldInfoPtr_localFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsMonitor<TOptions>.__c__DisplayClass10_0>.NativeClassPtr, "localFactory");
				OptionsMonitor<TOptions>.__c__DisplayClass10_0.NativeFieldInfoPtr_localName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsMonitor<TOptions>.__c__DisplayClass10_0>.NativeClassPtr, "localName");
				OptionsMonitor<TOptions>.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMonitor<TOptions>.__c__DisplayClass10_0>.NativeClassPtr, 100663364);
				OptionsMonitor<TOptions>.__c__DisplayClass10_0.NativeMethodInfoPtr__Get_b__1_Internal_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMonitor<TOptions>.__c__DisplayClass10_0>.NativeClassPtr, 100663365);
			}

			// Token: 0x060000F5 RID: 245 RVA: 0x00005EF8 File Offset: 0x000040F8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsMonitor<TOptions>.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsMonitor<TOptions>.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000F6 RID: 246 RVA: 0x00005F34 File Offset: 0x00004134
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TOptions _Get_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsMonitor<TOptions>.__c__DisplayClass10_0.NativeMethodInfoPtr__Get_b__1_Internal_TOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TOptions>(intPtr, false, true);
			}

			// Token: 0x060000F7 RID: 247 RVA: 0x0000276E File Offset: 0x0000096E
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x060000F8 RID: 248 RVA: 0x00005F70 File Offset: 0x00004170
			// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002777 File Offset: 0x00000977
			public unsafe IOptionsFactory<TOptions> localFactory
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsMonitor<TOptions>.__c__DisplayClass10_0.NativeFieldInfoPtr_localFactory);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOptionsFactory<TOptions>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsMonitor<TOptions>.__c__DisplayClass10_0.NativeFieldInfoPtr_localFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x060000FA RID: 250 RVA: 0x00005FA0 File Offset: 0x000041A0
			// (set) Token: 0x060000FB RID: 251 RVA: 0x00002796 File Offset: 0x00000996
			public unsafe string localName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsMonitor<TOptions>.__c__DisplayClass10_0.NativeFieldInfoPtr_localName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsMonitor<TOptions>.__c__DisplayClass10_0.NativeFieldInfoPtr_localName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400008C RID: 140
			private static readonly IntPtr NativeFieldInfoPtr_localFactory;

			// Token: 0x0400008D RID: 141
			private static readonly IntPtr NativeFieldInfoPtr_localName;

			// Token: 0x0400008E RID: 142
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400008F RID: 143
			private static readonly IntPtr NativeMethodInfoPtr__Get_b__1_Internal_TOptions_0;
		}
	}
}
