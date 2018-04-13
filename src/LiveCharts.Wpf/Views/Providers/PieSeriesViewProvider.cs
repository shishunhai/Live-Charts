﻿using LiveCharts.Core.Abstractions;
using LiveCharts.Core.Abstractions.DataSeries;
using LiveCharts.Core.Coordinates;
using LiveCharts.Core.Interaction;
using LiveCharts.Core.ViewModels;
using LiveCharts.Wpf.Controls;

namespace LiveCharts.Wpf.Views.Providers
{
    /// <summary>
    /// The pie view provider.
    /// </summary>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    /// <seealso cref="LiveCharts.Core.Abstractions.ISeriesViewProvider{TModel, PieCoordinate, PieViewModel}" />
    public class PieSeriesViewProvider<TModel>: ISeriesViewProvider<TModel, StackedPointCoordinate, PieViewModel>
    {
        /// <inheritdoc />
        public void OnUpdateStarted(IChartView chart, ISeries series)
        {
        }

        /// <inheritdoc />
        public IPointView<TModel, Point<TModel, StackedPointCoordinate, PieViewModel>, StackedPointCoordinate, PieViewModel> Getter()
        {
            return new PiePointView<TModel, Point<TModel, StackedPointCoordinate, PieViewModel>, DataLabel>();
        }

        /// <inheritdoc />
        public void OnUpdateFinished(IChartView chart, ISeries series)
        {
        }
    }
}