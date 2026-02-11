using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Options
{
	// Token: 0x0200001F RID: 31
	public sealed class UnnamedOptionsManager<TOptions> : Object where TOptions : class
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00004B3C File Offset: 0x00002D3C
		// Note: this type is marked as 'beforefieldinit'.
		static UnnamedOptionsManager()
		{
			Il2CppClassPointerStore<UnnamedOptionsManager<TOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "Microsoft.Extensions.Options", "UnnamedOptionsManager`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnnamedOptionsManager<TOptions>>.NativeClassPtr);
			UnnamedOptionsManager<TOptions>.NativeFieldInfoPtr__factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnnamedOptionsManager<TOptions>>.NativeClassPtr, "_factory");
			UnnamedOptionsManager<TOptions>.NativeFieldInfoPtr__syncObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnnamedOptionsManager<TOptions>>.NativeClassPtr, "_syncObj");
			UnnamedOptionsManager<TOptions>.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnnamedOptionsManager<TOptions>>.NativeClassPtr, "_value");
			UnnamedOptionsManager<TOptions>.NativeMethodInfoPtr__ctor_Public_Void_IOptionsFactory_1_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnnamedOptionsManager<TOptions>>.NativeClassPtr, 100663372);
			UnnamedOptionsManager<TOptions>.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnnamedOptionsManager<TOptions>>.NativeClassPtr, 100663373);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00004C0C File Offset: 0x00002E0C
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnnamedOptionsManager(IOptionsFactory<TOptions> factory)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnnamedOptionsManager<TOptions>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnnamedOptionsManager<TOptions>.NativeMethodInfoPtr__ctor_Public_Void_IOptionsFactory_1_TOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00004C58 File Offset: 0x00002E58
		public unsafe TOptions Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266051, XrefRangeEnd = 1266074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnnamedOptionsManager<TOptions>.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_TOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TOptions>(intPtr, false, true);
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000024D8 File Offset: 0x000006D8
		public UnnamedOptionsManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00004C94 File Offset: 0x00002E94
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x000024E1 File Offset: 0x000006E1
		public unsafe IOptionsFactory<TOptions> _factory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnnamedOptionsManager<TOptions>.NativeFieldInfoPtr__factory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOptionsFactory<TOptions>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnnamedOptionsManager<TOptions>.NativeFieldInfoPtr__factory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00004CC4 File Offset: 0x00002EC4
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00002500 File Offset: 0x00000700
		public unsafe Object _syncObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnnamedOptionsManager<TOptions>.NativeFieldInfoPtr__syncObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnnamedOptionsManager<TOptions>.NativeFieldInfoPtr__syncObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00004CF4 File Offset: 0x00002EF4
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00004D1C File Offset: 0x00002F1C
		public unsafe TOptions _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnnamedOptionsManager<TOptions>.NativeFieldInfoPtr__value);
				return IL2CPP.PointerToValueGeneric<TOptions>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnnamedOptionsManager<TOptions>.NativeFieldInfoPtr__value);
				Type typeFromHandle = typeof(TOptions);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr__factory;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr__syncObj;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IOptionsFactory_1_TOptions_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_TOptions_0;
	}
}
